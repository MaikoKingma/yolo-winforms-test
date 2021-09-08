
namespace Yolo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxLabels = new System.Windows.Forms.CheckedListBox();
            this.loadedPictureBox = new System.Windows.Forms.PictureBox();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.yoloBtn = new System.Windows.Forms.Button();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxLabels
            // 
            this.listBoxLabels.CheckOnClick = true;
            this.listBoxLabels.FormattingEnabled = true;
            this.listBoxLabels.Location = new System.Drawing.Point(12, 76);
            this.listBoxLabels.Name = "listBoxLabels";
            this.listBoxLabels.Size = new System.Drawing.Size(186, 544);
            this.listBoxLabels.Sorted = true;
            this.listBoxLabels.TabIndex = 1;
            // 
            // loadedPictureBox
            // 
            this.loadedPictureBox.Location = new System.Drawing.Point(232, 12);
            this.loadedPictureBox.Name = "loadedPictureBox";
            this.loadedPictureBox.Size = new System.Drawing.Size(567, 304);
            this.loadedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadedPictureBox.TabIndex = 2;
            this.loadedPictureBox.TabStop = false;
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Location = new System.Drawing.Point(232, 322);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(567, 304);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultPictureBox.TabIndex = 3;
            this.resultPictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(12, 18);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(75, 23);
            this.openFileBtn.TabIndex = 4;
            this.openFileBtn.Text = "Load";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // yoloBtn
            // 
            this.yoloBtn.Location = new System.Drawing.Point(123, 18);
            this.yoloBtn.Name = "yoloBtn";
            this.yoloBtn.Size = new System.Drawing.Size(75, 23);
            this.yoloBtn.TabIndex = 5;
            this.yoloBtn.Text = "Yolo";
            this.yoloBtn.UseVisualStyleBackColor = true;
            this.yoloBtn.Click += new System.EventHandler(this.yoloBtn_Click);
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(13, 47);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(185, 23);
            this.categoriesComboBox.Sorted = true;
            this.categoriesComboBox.TabIndex = 6;
            this.categoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriesComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 639);
            this.Controls.Add(this.categoriesComboBox);
            this.Controls.Add(this.yoloBtn);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.loadedPictureBox);
            this.Controls.Add(this.listBoxLabels);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.loadedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listBoxLabels;
        private System.Windows.Forms.PictureBox loadedPictureBox;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Button yoloBtn;
        private System.Windows.Forms.ComboBox categoriesComboBox;
    }
}

