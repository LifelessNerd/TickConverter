using System;
using System.Drawing;
using System.Windows.Forms;

namespace TickConverter
{
    class previewImage : Form
    {
        private RichTextBox richTextBox1;
        private Button previewImageButton;
        private Button generateImageButton;
        private Label titleLabel;
        private PictureBox previewPicture;
        private Button fileOpenButton;
        private Button selectFontButton;
        private Bitmap uncroppedImage;
        private Bitmap outputImage;

        public previewImage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.previewImageButton = new System.Windows.Forms.Button();
            this.generateImageButton = new System.Windows.Forms.Button();
            this.previewPicture = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.fileOpenButton = new System.Windows.Forms.Button();
            this.selectFontButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previewPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 136);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(306, 185);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // previewImageButton
            // 
            this.previewImageButton.Location = new System.Drawing.Point(25, 406);
            this.previewImageButton.Name = "previewImageButton";
            this.previewImageButton.Size = new System.Drawing.Size(98, 36);
            this.previewImageButton.TabIndex = 3;
            this.previewImageButton.Text = "Preview image";
            this.previewImageButton.UseVisualStyleBackColor = true;
            // 
            // generateImageButton
            // 
            this.generateImageButton.Location = new System.Drawing.Point(129, 407);
            this.generateImageButton.Name = "generateImageButton";
            this.generateImageButton.Size = new System.Drawing.Size(98, 36);
            this.generateImageButton.TabIndex = 4;
            this.generateImageButton.Text = "Generate image and Save";
            this.generateImageButton.UseVisualStyleBackColor = true;
            // 
            // previewPicture
            // 
            this.previewPicture.Location = new System.Drawing.Point(358, 26);
            this.previewPicture.Name = "previewPicture";
            this.previewPicture.Size = new System.Drawing.Size(636, 416);
            this.previewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPicture.TabIndex = 5;
            this.previewPicture.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(327, 51);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Input a list and an image, to create a summary of realtime playtime in picture fo" +
    "rm";
            // 
            // fileOpenButton
            // 
            this.fileOpenButton.Location = new System.Drawing.Point(25, 78);
            this.fileOpenButton.Name = "fileOpenButton";
            this.fileOpenButton.Size = new System.Drawing.Size(98, 37);
            this.fileOpenButton.TabIndex = 2;
            this.fileOpenButton.Text = "Select image...";
            this.fileOpenButton.UseVisualStyleBackColor = true;
            this.fileOpenButton.Click += new System.EventHandler(this.fileOpenButton_Click);
            // 
            // selectFontButton
            // 
            this.selectFontButton.Location = new System.Drawing.Point(129, 78);
            this.selectFontButton.Name = "selectFontButton";
            this.selectFontButton.Size = new System.Drawing.Size(98, 37);
            this.selectFontButton.TabIndex = 7;
            this.selectFontButton.Text = "Select font...";
            this.selectFontButton.UseVisualStyleBackColor = true;
            this.selectFontButton.Click += new System.EventHandler(this.selectFontButton_Click);
            // 
            // previewImage
            // 
            this.ClientSize = new System.Drawing.Size(1024, 476);
            this.Controls.Add(this.selectFontButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.previewPicture);
            this.Controls.Add(this.generateImageButton);
            this.Controls.Add(this.previewImageButton);
            this.Controls.Add(this.fileOpenButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "previewImage";
            ((System.ComponentModel.ISupportInitialize)(this.previewPicture)).EndInit();
            this.ResumeLayout(false);

        }

        private void fileOpenButton_Click(object sender, System.EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG files|*.jpg|PNG files|*.png|All files|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    
                    uncroppedImage = new Bitmap(imageLocation);
                    outputImage = new Bitmap(uncroppedImage, new Size(1920, 1080));

                    Graphics graphics = Graphics.FromImage(outputImage);
                    graphics.FillRectangle(Brushes.Black, 10, 10, 200, 200);



                    previewPicture.Image = outputImage;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectFontButton_Click(object sender, EventArgs e)
        {

        }
    }
}