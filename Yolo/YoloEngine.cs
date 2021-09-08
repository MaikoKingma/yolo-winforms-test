using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Yolo.Domain;

namespace Yolo
{
    class YoloEngine
    {
        private const string _allCategoriesId = "...";
        private const string _modelPath = @".\Assets\Models\yolov4.onnx";
        private const string _imageFolder = @".\Assets\Data";
        private const string _imageOutputFolder = @".\Assets\Output";
        private const string _labelFile = @".\Assets\Labels.json";

        private IEnumerable<Label> labels;

        private Predictor predictor;

        public YoloEngine()
        {
            Directory.CreateDirectory(_imageOutputFolder);
            var trainer = new Trainer();
            var trainedModel = trainer.BuildAndTrain(_modelPath);
            predictor = new Predictor(trainedModel);

            labels = JsonSerializer.Deserialize<IEnumerable<Label>>(File.ReadAllText(_labelFile));
        }

        public string[] GetLabels(string category = _allCategoriesId)
        {
            var labelSubset = labels;
            if (category != _allCategoriesId)
            {
                labelSubset = labels.Where(label => label.Category == category);
            }
            return labelSubset.Select(label => label.Name).ToArray();
        }

        public string[] GetCategories()
        {
            var categories = labels.Select(label => label.Category).Distinct().ToList();
            categories.Add(_allCategoriesId);
            return categories.ToArray();
        }

        public string Yolo(string[] labels, string imageFile)
        {
            using var image = new Bitmap(Image.FromFile(imageFile));
            var predict = predictor.Predict(image);
            var results = predict.GetResults(labels);

            return DrawResults.DrawAndStore(_imageOutputFolder, new FileInfo(imageFile).Name, results, image);
        }

        public string GetPreviewFile()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(_imageFolder);
            var files = directoryInfo.GetFiles();
            if (files.Length > 0)
            {
                return directoryInfo.GetFiles()[0].FullName;
            }
            return null;
        }
    }
}
