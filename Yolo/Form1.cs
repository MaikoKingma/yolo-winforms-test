using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yolo
{
    public partial class Form1 : Form
    {
        private YoloEngine yoloEngine = new YoloEngine();
        private string[] listBoxDataSource;
        private string[] comboBoxDataSource;
        public Form1()
        {
            comboBoxDataSource = yoloEngine.GetCategories();
            listBoxDataSource = yoloEngine.GetLabels();

            InitializeComponent();

            categoriesComboBox.DataSource = comboBoxDataSource;
            listBoxLabels.DataSource = listBoxDataSource;
            selectAllLabels();

            var previewFile = yoloEngine.GetPreviewFile();
            if (previewFile != null)
            {
                openFileDialog1.FileName = previewFile;
                loadedPictureBox.Load(openFileDialog1.FileName);
            }
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadedPictureBox.Load(openFileDialog1.FileName);
            }
        }

        private void yoloBtn_Click(object sender, EventArgs e)
        {
            var labels = listBoxLabels.CheckedItems.OfType<string>().ToArray();
            var imageFile = yoloEngine.Yolo(labels, openFileDialog1.FileName);
            resultPictureBox.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(imageFile)));
        }

        private void categoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDataSource = yoloEngine.GetLabels((string)categoriesComboBox.SelectedItem);
            listBoxLabels.DataSource = listBoxDataSource;
            selectAllLabels();
        }

        private void selectAllLabels()
        {
            for (int i = 0; i < listBoxLabels.Items.Count; i++)
            {
                listBoxLabels.SetItemChecked(i, true);
            }
        }
    }
}
