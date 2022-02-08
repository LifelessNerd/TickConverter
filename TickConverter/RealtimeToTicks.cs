using System;
using System.Windows.Forms;

namespace TickConverter
{
    public class RealtimeToTicks : Form
    {
        private TextBox textBoxMinutes;
        private TextBox textBoxHours;
        private TextBox textBoxDays;
        private Label label1;
        private TextBox textBoxTicks;
        private TextBox textBoxSeconds;
        private Label labelDHMS;
        private Button calculateTicksButton;
        private Label TitleText;

        public RealtimeToTicks()
        {
            //Constructor
            InitializeComponent();
            this.Icon = Properties.Resources.Icon;
        }

        private void InitializeComponent()
        {
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTicks = new System.Windows.Forms.TextBox();
            this.TitleText = new System.Windows.Forms.Label();
            this.textBoxSeconds = new System.Windows.Forms.TextBox();
            this.labelDHMS = new System.Windows.Forms.Label();
            this.calculateTicksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMinutes.Location = new System.Drawing.Point(204, 145);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(63, 20);
            this.textBoxMinutes.TabIndex = 15;
            this.textBoxMinutes.Text = "0";
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(136, 145);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(66, 20);
            this.textBoxHours.TabIndex = 14;
            this.textBoxHours.Text = "0";
            // 
            // textBoxDays
            // 
            this.textBoxDays.Location = new System.Drawing.Point(59, 145);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(75, 20);
            this.textBoxDays.TabIndex = 13;
            this.textBoxDays.Text = "0";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Input realtime to be converted";
            // 
            // textBoxTicks
            // 
            this.textBoxTicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTicks.Location = new System.Drawing.Point(43, 241);
            this.textBoxTicks.Name = "textBoxTicks";
            this.textBoxTicks.ReadOnly = true;
            this.textBoxTicks.Size = new System.Drawing.Size(336, 31);
            this.textBoxTicks.TabIndex = 20;
            this.textBoxTicks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TitleText
            // 
            this.TitleText.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.Location = new System.Drawing.Point(12, 9);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(399, 67);
            this.TitleText.TabIndex = 9;
            this.TitleText.Text = "Ticks Converter";
            this.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSeconds
            // 
            this.textBoxSeconds.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSeconds.Location = new System.Drawing.Point(269, 145);
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.Size = new System.Drawing.Size(77, 20);
            this.textBoxSeconds.TabIndex = 16;
            this.textBoxSeconds.Text = "0";
            // 
            // labelDHMS
            // 
            this.labelDHMS.AutoSize = true;
            this.labelDHMS.Location = new System.Drawing.Point(58, 129);
            this.labelDHMS.Name = "labelDHMS";
            this.labelDHMS.Size = new System.Drawing.Size(261, 13);
            this.labelDHMS.TabIndex = 17;
            this.labelDHMS.Text = "Days                 Hours              Minutes          Seconds";
            // 
            // calculateTicksButton
            // 
            this.calculateTicksButton.Location = new System.Drawing.Point(120, 179);
            this.calculateTicksButton.Name = "calculateTicksButton";
            this.calculateTicksButton.Size = new System.Drawing.Size(174, 42);
            this.calculateTicksButton.TabIndex = 18;
            this.calculateTicksButton.Text = "Calculate";
            this.calculateTicksButton.UseVisualStyleBackColor = true;
            this.calculateTicksButton.Click += new System.EventHandler(this.calculateTicksButton_Click);
            // 
            // RealtimeToTicks
            // 
            this.ClientSize = new System.Drawing.Size(419, 314);
            this.Controls.Add(this.calculateTicksButton);
            this.Controls.Add(this.labelDHMS);
            this.Controls.Add(this.textBoxSeconds);
            this.Controls.Add(this.textBoxMinutes);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.textBoxDays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTicks);
            this.Controls.Add(this.TitleText);
            this.Name = "RealtimeToTicks";
            this.Text = "Realtime to Ticks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void calculateTicksButton_Click(object sender, System.EventArgs e)
        {
            try
            {

                int days = Int32.Parse(textBoxDays.Text);
                int hours = Int32.Parse(textBoxHours.Text);
                int minutes = Int32.Parse(textBoxMinutes.Text);
                int seconds = Int32.Parse(textBoxSeconds.Text);

                int answer = days * 24 * 60 * 60 * 20 + hours * 60 * 60 * 20 + minutes * 60 * 20 + seconds * 20;
                textBoxTicks.Text = answer.ToString();
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}