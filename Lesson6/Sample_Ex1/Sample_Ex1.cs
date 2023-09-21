using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Ex1
{
    public partial class Sample_Ex1 : Form
    {
        public Sample_Ex1()
        {
            InitializeComponent();
            InitializeComponent();

            // Initialize the timer
            Timer timer1 = new Timer();
            timer1.Interval = 1000;  // Set the interval to 1 second (1000 milliseconds)
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToString();
        }
    }
}
