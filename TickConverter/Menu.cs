using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickConverter
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            //Formatting is done in the designer

        }

        private void toRealtimeButton_Click(object sender, EventArgs e)
        {
            
            TicksToRealTime ticksToRealtime = new TicksToRealTime();
            Form menu = this;
            this.Hide();
            ticksToRealtime.ShowDialog();
            //Paused
            this.Show();
        }

        private void toTicksButton_Click(object sender, EventArgs e)
        {
            RealtimeToTicks realtimeToTicks = new RealtimeToTicks();
            Form menu = this;
            this.Hide();
            realtimeToTicks.ShowDialog();
            //Paused
            this.Show();
        }

        private void ListToRealtimeButton_Click(object sender, EventArgs e)
        {
            ListToRealtime listToRealtime = new ListToRealtime();
            Form menu = this;
            this.Hide();
            listToRealtime.ShowDialog();
            //Paused
            this.Show();
        }

        private void createPictureButton_Click(object sender, EventArgs e)
        {
            previewImage imageCreator = new previewImage();
            Form menu = this;
            this.Hide();
            imageCreator.ShowDialog();
            //Paused
            this.Show();
        }
    }
}
