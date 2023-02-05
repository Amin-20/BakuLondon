using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            timer.Start();
        }

        Button button1 = new Button();

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void LondonBtn_MouseClick(object sender, MouseEventArgs e)
        {
            LondonBtn.Dispose();
            timeLbl.Dispose();
            button1.Name = "BakuBtn";
            button1.Text = "BAKU";
            button1.Font = new Font("ROG Fonts", 28, FontStyle.Bold);
            Random random = new Random();
            button1.Location = new Point(80, 450);
            button1.ForeColor = Color.Navy;
            button1.AutoSize = true;
            button1.MouseClick += LondonBtn_MouseClick;
            this.Controls.Add(button1);
            this.BackgroundImage = Properties.Resources.londn;
            timeLbl.Text = DateTime.Now.AddHours(4).ToLongTimeString();
        }

        private void BakuBtn_MauseClick(object sender, EventArgs e)
        {
            
        }

    }
}
