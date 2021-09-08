using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolo.Domain;

namespace Yolo
{
    public class Predictor
    {
        private MLContext _mLContext;
        private PredictionEngine<ImageData, ImagePrediction> _predictionEngine;

        public Predictor(ITransformer trainedModel)
        {
            _mLContext = new MLContext();
            _predictionEngine = _mLContext.Model
                               .CreatePredictionEngine<ImageData, ImagePrediction>(trainedModel);
        }

        public ImagePrediction Predict(Bitmap image)
        {
            return _predictionEngine.Predict(new ImageData() { Image = image });
        }
    }
}
