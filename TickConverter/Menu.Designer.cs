namespace TickConverter
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.toRealtimeButton = new System.Windows.Forms.Button();
            this.TitleText = new System.Windows.Forms.Label();
            this.toTicksButton = new System.Windows.Forms.Button();
            this.fromTicksLabel = new System.Windows.Forms.Label();
            this.fromRealtimeLabel = new System.Windows.Forms.Label();
            this.ListToRealtimeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toRealtimeButton
            // 
            this.toRealtimeButton.Location = new System.Drawing.Point(39, 106);
            this.toRealtimeButton.Name = "toRealtimeButton";
            this.toRealtimeButton.Size = new System.Drawing.Size(97, 52);
            this.toRealtimeButton.TabIndex = 0;
            this.toRealtimeButton.Text = "To Realtime";
            this.toRealtimeButton.UseVisualStyleBackColor = true;
            this.toRealtimeButton.Click += new System.EventHandler(this.toRealtimeButton_Click);
            // 
            // TitleText
            // 
            this.TitleText.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.Location = new System.Drawing.Point(12, 9);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(375, 67);
            this.TitleText.TabIndex = 1;
            this.TitleText.Text = "Ticks Converter";
            this.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toTicksButton
            // 
            this.toTicksButton.Location = new System.Drawing.Point(263, 106);
            this.toTicksButton.Name = "toTicksButton";
            this.toTicksButton.Size = new System.Drawing.Size(97, 52);
            this.toTicksButton.TabIndex = 2;
            this.toTicksButton.Text = "To Ticks";
            this.toTicksButton.UseVisualStyleBackColor = true;
            this.toTicksButton.Click += new System.EventHandler(this.toTicksButton_Click);
            // 
            // fromTicksLabel
            // 
            this.fromTicksLabel.AutoSize = true;
            this.fromTicksLabel.Location = new System.Drawing.Point(57, 76);
            this.fromTicksLabel.Name = "fromTicksLabel";
            this.fromTicksLabel.Size = new System.Drawing.Size(56, 13);
            this.fromTicksLabel.TabIndex = 3;
            this.fromTicksLabel.Text = "from Ticks";
            // 
            // fromRealtimeLabel
            // 
            this.fromRealtimeLabel.AutoSize = true;
            this.fromRealtimeLabel.Location = new System.Drawing.Point(280, 76);
            this.fromRealtimeLabel.Name = "fromRealtimeLabel";
            this.fromRealtimeLabel.Size = new System.Drawing.Size(71, 13);
            this.fromRealtimeLabel.TabIndex = 4;
            this.fromRealtimeLabel.Text = "from Realtime";
            // 
            // ListToRealtimeButton
            // 
            this.ListToRealtimeButton.Location = new System.Drawing.Point(39, 164);
            this.ListToRealtimeButton.Name = "ListToRealtimeButton";
            this.ListToRealtimeButton.Size = new System.Drawing.Size(97, 52);
            this.ListToRealtimeButton.TabIndex = 5;
            this.ListToRealtimeButton.Text = "List To Realtime";
            this.ListToRealtimeButton.UseVisualStyleBackColor = true;
            this.ListToRealtimeButton.Click += new System.EventHandler(this.ListToRealtimeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ListToRealtimeButton);
            this.Controls.Add(this.fromRealtimeLabel);
            this.Controls.Add(this.fromTicksLabel);
            this.Controls.Add(this.toTicksButton);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.toRealtimeButton);
            this.Name = "Menu";
            this.Text = "Ticks Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toRealtimeButton;
        private System.Windows.Forms.Label TitleText;
        private System.Windows.Forms.Button toTicksButton;
        private System.Windows.Forms.Label fromTicksLabel;
        private System.Windows.Forms.Label fromRealtimeLabel;
        private System.Windows.Forms.Button ListToRealtimeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

