using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TickConverter
{
    public class ListToRealtime : Form
    {
        private Label label1;
        private Button buttonHelp;
        private RichTextBox richTextBoxInput;
        private RichTextBox richTextBoxOutput;
        private Label label3;
        private Button CalculateButton;
        private Label TitleText;

        public ListToRealtime() 
        {
            //Constructor
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TitleText = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input a list of ticks and players to be converted";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleText
            // 
            this.TitleText.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleText.Location = new System.Drawing.Point(8, 9);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(399, 67);
            this.TitleText.TabIndex = 5;
            this.TitleText.Text = "Ticks Converter";
            this.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(314, 80);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(70, 51);
            this.buttonHelp.TabIndex = 7;
            this.buttonHelp.Text = "Formatting help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(19, 148);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(289, 46);
            this.richTextBoxInput.TabIndex = 8;
            this.richTextBoxInput.Text = "";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(19, 200);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(378, 171);
            this.richTextBoxOutput.TabIndex = 9;
            this.richTextBoxOutput.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Input";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(315, 148);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(70, 46);
            this.CalculateButton.TabIndex = 12;
            this.CalculateButton.Text = "Calculate and Format";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ListToRealtime
            // 
            this.ClientSize = new System.Drawing.Size(419, 399);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.richTextBoxInput);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleText);
            this.Name = "ListToRealtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonHelp_Click(object sender, System.EventArgs e)
        {
            
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
            //Paused

        }

        private void CalculateButton_Click(object sender, System.EventArgs e)
        {
            try
            {   
                richTextBoxOutput.Text = "";

                string input = this.richTextBoxInput.Text;
                input = input.TrimStart('{');
                input = input.TrimEnd('}');
                Dictionary<String, String> tickData = new Dictionary<String, String>();

                String[] entries = input.Split(',');
                
                foreach (string entry in entries)
                {
                    String[] entryData = entry.Split('=');
                    tickData.Add(entryData[0], entryData[1]);

                    int ticks = Int32.Parse(tickData[entryData[0]]);
                    int secs = ticks / 20;
                    Console.WriteLine(ticks);
                    TimeSpan t = TimeSpan.FromSeconds(secs);
                    string richAnswer = string.Format("{0:D1}d, {1:D1}h, {2:D1}m, {3:D1}s", t.Days, t.Hours, t.Minutes, t.Seconds);

                    richTextBoxOutput.Text = richTextBoxOutput.Text + entryData[0] + " - " + richAnswer + "\n";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}