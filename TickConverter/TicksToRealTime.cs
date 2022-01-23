using System;
using System.Windows.Forms;

namespace TickConverter
{
    public class TicksToRealTime : Form
    {
        private Label TitleText;
        private TextBox textBoxInput;
        private RichTextBox richTextBoxRealtime;
        private TextBox textBoxDays;
        private TextBox textBoxHours;
        private TextBox textBoxMinutes;
        private Label label1;

        public TicksToRealTime()
        {
            //Constructor
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.TitleText = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxRealtime = new System.Windows.Forms.RichTextBox();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TitleText
            // 
            this.TitleText.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.Location = new System.Drawing.Point(12, 9);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(399, 67);
            this.TitleText.TabIndex = 2;
            this.TitleText.Text = "Ticks Converter";
            this.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(46, 118);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(326, 31);
            this.textBoxInput.TabIndex = 3;
            this.textBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input ticks to be converted";
            // 
            // richTextBoxRealtime
            // 
            this.richTextBoxRealtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxRealtime.Location = new System.Drawing.Point(46, 184);
            this.richTextBoxRealtime.Name = "richTextBoxRealtime";
            this.richTextBoxRealtime.Size = new System.Drawing.Size(326, 41);
            this.richTextBoxRealtime.TabIndex = 5;
            this.richTextBoxRealtime.Text = "";
            // 
            // textBoxDays
            // 
            this.textBoxDays.Location = new System.Drawing.Point(46, 249);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(100, 20);
            this.textBoxDays.TabIndex = 6;
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(159, 249);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(100, 20);
            this.textBoxHours.TabIndex = 7;
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMinutes.Location = new System.Drawing.Point(272, 249);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinutes.TabIndex = 8;
            // 
            // TicksToRealTime
            // 
            this.ClientSize = new System.Drawing.Size(423, 314);
            this.Controls.Add(this.textBoxMinutes);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.textBoxDays);
            this.Controls.Add(this.richTextBoxRealtime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.TitleText);
            this.Name = "TicksToRealTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBoxInput_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (textBoxInput.Text != null)
                {
                    int ticks = Int32.Parse(textBoxInput.Text);
                    int secs = ticks / 20;
                    TimeSpan t = TimeSpan.FromSeconds(secs);

                    string richAnswer = string.Format("{0:D1}d, {1:D1}h, {2:D1}m, {3:D1}s", t.Days, t.Hours, t.Minutes, t.Seconds);
                    string daysAnswer = ((float)( secs / 60 / 60 / 24)).ToString() + " d";
                    string hoursAnswer = ((float)(secs / 60 / 60)).ToString() + " h";
                    string minutesAnswer = ((float)(secs / 60)).ToString() + " m";
                    richTextBoxRealtime.Text = richAnswer;
                    textBoxDays.Text = daysAnswer;
                    textBoxHours.Text = hoursAnswer;
                    textBoxMinutes.Text = minutesAnswer;
                }
            }
            catch (Exception exception)
            {
                if (textBoxInput.Text.Length > 1)
                {
                    MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxInput.Text = "";
                }
            }
        }
    }
}