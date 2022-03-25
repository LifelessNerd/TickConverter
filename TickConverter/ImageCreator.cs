using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace TickConverter
{
    class previewImage : Form
    {
        
        private RichTextBox inputBox;
        private Button previewImageButton;
        private Button generateImageButton;
        private Label titleLabel;
        private PictureBox previewPicture;
        private Button fileOpenButton;
        private Button selectFontButton;
        private Bitmap uncroppedImage;
        private Bitmap outputImage;
        private FontDialog fontDialog;
        private ColorDialog colorDialog;
        private ColorDialog accentColorDialog;
        private Font tekstFont;
        private Font playTimeFont;
        private Button helpButton;
        private Brush kleurBrush;
        private Brush accentKleurBrush;
        private Brush transKleurBrush;
        private Color kleurColor;
        private Color transKleurColor;
        private Color accentKleurColor;
        private Button selectKleur;
        private Button selectAKleur;
        private String imageLocation;
        Rectangle[] rectangles = new Rectangle[6];
        Point[] titlePoints = new Point[6];
        Point[] contentPoints = new Point[6];
        Point[] imagePoints = new Point[6];
        Point[] playtimePoints = new Point[6];
        string url;



        public previewImage()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.Icon;

            fontDialog = new FontDialog();
            colorDialog = new ColorDialog();
            accentColorDialog = new ColorDialog();
            fontDialog.MinSize = 16;
            fontDialog.MaxSize = 64;
            tekstFont = new Font("Coolvetica RG", 42, FontStyle.Regular);
            playTimeFont = new Font("Coolvetica RG", 64, FontStyle.Regular);
            fontDialog.Font = tekstFont;
            kleurColor = Color.FromArgb(255, Color.Black);
            transKleurColor = Color.FromArgb(150, Color.Black);
            accentKleurColor = Color.FromArgb(255,255,255,255);
            accentKleurBrush = new SolidBrush(accentKleurColor);
            kleurBrush = new SolidBrush(kleurColor);
            transKleurBrush = new SolidBrush(transKleurColor);


            rectangles[0] = new Rectangle(30, 46, 600, 470);
            rectangles[1] = new Rectangle(660, 46, 600, 470);
            rectangles[2] = new Rectangle(1290, 46, 600, 470);
            rectangles[3] = new Rectangle(30, 563, 600, 470);
            rectangles[4] = new Rectangle(660, 563, 600, 470);
            rectangles[5] = new Rectangle(1290, 563, 600, 470);

            for (int k = 0; k < 6; k++)
            {
                titlePoints[k] = new Point(rectangles[k].X + 410, rectangles[k].Y + 120);
                imagePoints[k] = new Point(rectangles[k].X + 30, rectangles[k].Y + 30);
                playtimePoints[k] = new Point(rectangles[k].X + 300, rectangles[k].Y + 350);
            }

            url = "https://minecraftskinstealer.com/api/v1/skin/download/face/";

        }

        private void InitializeComponent()
        {
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.previewImageButton = new System.Windows.Forms.Button();
            this.generateImageButton = new System.Windows.Forms.Button();
            this.previewPicture = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.fileOpenButton = new System.Windows.Forms.Button();
            this.selectFontButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.selectKleur = new System.Windows.Forms.Button();
            this.selectAKleur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previewPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(25, 136);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(306, 185);
            this.inputBox.TabIndex = 1;
            this.inputBox.Text = "{John=8000,Jack=10000,Luke=10001,LifelessNerd=6000,Callum=20,Luka=121722}";
            // 
            // previewImageButton
            // 
            this.previewImageButton.Location = new System.Drawing.Point(25, 406);
            this.previewImageButton.Name = "previewImageButton";
            this.previewImageButton.Size = new System.Drawing.Size(98, 36);
            this.previewImageButton.TabIndex = 3;
            this.previewImageButton.Text = "Preview image";
            this.previewImageButton.UseVisualStyleBackColor = true;
            this.previewImageButton.Click += new System.EventHandler(this.previewImageButton_Click);
            // 
            // generateImageButton
            // 
            this.generateImageButton.Location = new System.Drawing.Point(129, 407);
            this.generateImageButton.Name = "generateImageButton";
            this.generateImageButton.Size = new System.Drawing.Size(98, 36);
            this.generateImageButton.TabIndex = 4;
            this.generateImageButton.Text = "Generate image and Save";
            this.generateImageButton.UseVisualStyleBackColor = true;
            this.generateImageButton.Click += new System.EventHandler(this.generateImageButton_Click);
            // 
            // previewPicture
            // 
            this.previewPicture.Location = new System.Drawing.Point(345, 9);
            this.previewPicture.Name = "previewPicture";
            this.previewPicture.Size = new System.Drawing.Size(828, 483);
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
            this.fileOpenButton.Location = new System.Drawing.Point(19, 78);
            this.fileOpenButton.Name = "fileOpenButton";
            this.fileOpenButton.Size = new System.Drawing.Size(73, 37);
            this.fileOpenButton.TabIndex = 2;
            this.fileOpenButton.Text = "Select image...";
            this.fileOpenButton.UseVisualStyleBackColor = true;
            this.fileOpenButton.Click += new System.EventHandler(this.fileOpenButton_Click);
            // 
            // selectFontButton
            // 
            this.selectFontButton.Location = new System.Drawing.Point(98, 78);
            this.selectFontButton.Name = "selectFontButton";
            this.selectFontButton.Size = new System.Drawing.Size(73, 37);
            this.selectFontButton.TabIndex = 7;
            this.selectFontButton.Text = "Select font...";
            this.selectFontButton.UseVisualStyleBackColor = true;
            this.selectFontButton.Click += new System.EventHandler(this.selectFontButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(238, 273);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(84, 40);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "Formatting help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // selectKleur
            // 
            this.selectKleur.Location = new System.Drawing.Point(177, 78);
            this.selectKleur.Name = "selectKleur";
            this.selectKleur.Size = new System.Drawing.Size(73, 37);
            this.selectKleur.TabIndex = 10;
            this.selectKleur.Text = "Select main color...";
            this.selectKleur.UseVisualStyleBackColor = true;
            this.selectKleur.Click += new System.EventHandler(this.selectKleur_Click);
            // 
            // selectAKleur
            // 
            this.selectAKleur.Location = new System.Drawing.Point(256, 78);
            this.selectAKleur.Name = "selectAKleur";
            this.selectAKleur.Size = new System.Drawing.Size(73, 37);
            this.selectAKleur.TabIndex = 11;
            this.selectAKleur.Text = "Select accent...";
            this.selectAKleur.UseVisualStyleBackColor = true;
            this.selectAKleur.Click += new System.EventHandler(this.selectAKleur_Click);
            // 
            // previewImage
            // 
            this.ClientSize = new System.Drawing.Size(1181, 501);
            this.Controls.Add(this.selectAKleur);
            this.Controls.Add(this.selectKleur);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.selectFontButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.previewPicture);
            this.Controls.Add(this.generateImageButton);
            this.Controls.Add(this.previewImageButton);
            this.Controls.Add(this.fileOpenButton);
            this.Controls.Add(this.inputBox);
            this.Name = "previewImage";
            ((System.ComponentModel.ISupportInitialize)(this.previewPicture)).EndInit();
            this.ResumeLayout(false);

        }

        private void fileOpenButton_Click(object sender, System.EventArgs e)
        {
            imageLocation = "";
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "PNG files|*.png|JPG files|*.jpg|All files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = openFileDialog.FileName;
                    fileOpenButton.BackColor = Color.Green;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectFontButton_Click(object sender, EventArgs e)
        {
            
            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                tekstFont = fontDialog.Font;
                DialogResult fontWarning = MessageBox.Show("Not all fonts will align in the picture. Be sure to preview the image before saving.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void previewImageButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                //Creates bitmap and crops it to 1920x1080
                uncroppedImage = new Bitmap(imageLocation);
                outputImage = new Bitmap(uncroppedImage, new Size(1920, 1080));

                //Blur
                Blur blur = new Blur(outputImage);
                outputImage = blur.Process(5);

                //Set pictureBox image to outputImage after blur
                previewPicture.Image = outputImage;
                Graphics gr = Graphics.FromImage(outputImage);

                Dictionary<String, TimeSpan> realtimeData = dataToDictionary();

                Draw(gr, realtimeData);
                
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void Draw(Graphics gr, Dictionary<String, TimeSpan> data)
        {
            

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
   
            gr.FillRectangles(transKleurBrush, rectangles);

            var sortedDict = from entry in data orderby entry.Value descending select entry;
            Dictionary<String, TimeSpan> sortedDataDict = sortedDict.ToDictionary<KeyValuePair<String, TimeSpan>, String, TimeSpan>(pair => pair.Key, pair => pair.Value);
            try
            {
                
                WebClient client = new WebClient();

                //Content drawing
                for (int teller = 0; teller < 6; teller++)
                {
                    //Name
                    gr.DrawString(sortedDataDict.ElementAt(teller).Key, tekstFont, accentKleurBrush, titlePoints[teller], stringFormat);
                    //Head + outline
                    Stream stream = client.OpenRead(url + sortedDataDict.ElementAt(teller).Key);
                    Bitmap bustImage = new Bitmap(stream);
                    gr.FillRectangle(kleurBrush, new Rectangle(imagePoints[teller].X - 10, imagePoints[teller].Y - 10, 220, 220));
                    gr.DrawImage(bustImage, new Rectangle(imagePoints[teller], new Size(200,200)));

                    //Playtime
                    TimeSpan playTime = data.ElementAt(teller).Value;
                    string richAnswer = string.Format("{0:D1}d, {1:D1}h, {2:D1}m, {3:D1}s", playTime.Days, playTime.Hours, playTime.Minutes, playTime.Seconds);
                    gr.DrawString(richAnswer, new Font(tekstFont.FontFamily, tekstFont.Size + 16, FontStyle.Regular), accentKleurBrush, playtimePoints[teller], stringFormat);
                }
                

            } catch (Exception ex) { DialogResult res = MessageBox.Show("Invalid list of players, you need 6 entries"); } //Waarschijnlijk is lijst niet lang genoeg


        }

        private Dictionary<String, TimeSpan> dataToDictionary()
        {
            try
            {

                string input = this.inputBox.Text;
                input = input.TrimStart('{');
                input = input.TrimEnd('}');
                Dictionary<String, String> tickData = new Dictionary<String, String>();
                Dictionary<String, TimeSpan> realtimeData = new Dictionary<String, TimeSpan>();

                String[] entries = input.Split(',');

                foreach (string entry in entries)
                {
                    String[] entryData = entry.Split('=');
                    tickData.Add(entryData[0], entryData[1]);

                    int ticks = Int32.Parse(tickData[entryData[0]]);
                    int secs = ticks / 20;

                    TimeSpan t = TimeSpan.FromSeconds(secs);
                    realtimeData.Add(entryData[0], t);
                    string richAnswer = string.Format("{0:D1}d, {1:D1}h, {2:D1}m, {3:D1}s", t.Days, t.Hours, t.Minutes, t.Seconds);

                }
                
                return realtimeData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
            //Paused
        }

        private void selectKleur_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {

                kleurColor = colorDialog.Color;
                transKleurColor = Color.FromArgb(150, kleurColor);

                //Update
                accentKleurBrush = new SolidBrush(accentKleurColor);
                kleurBrush = new SolidBrush(kleurColor);
                transKleurBrush = new SolidBrush(transKleurColor);
            }
        }

        private void selectAKleur_Click(object sender, EventArgs e)
        {
            if (accentColorDialog.ShowDialog() == DialogResult.OK)
            {
                accentKleurColor = accentColorDialog.Color;

                //Update
                accentKleurBrush = new SolidBrush(accentKleurColor);
                kleurBrush = new SolidBrush(kleurColor);
                transKleurBrush = new SolidBrush(transKleurColor);
            }
        }

        private void generateImageButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG files | *.png | JPG files | *.jpg | JPEG files | *.jpeg";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputImage.Save(saveFileDialog.FileName);
            }
        }
    }

}