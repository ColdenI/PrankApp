using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrankApp
{
    public partial class Form1 : Form
    {

        private string Button1Text, Button2Text, Text1, Text2, Password;
        private Point[] points = { new Point(412, 284), new Point(313, 224), new Point(498, 121), new Point(610, 229), new Point(330, 333), new Point(70, 200), new Point(100, 20), new Point(534, 30)};
        private int PosIndex = 0;
        private bool isClosed = true;

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Text2;
            button1.Visible = false;
            button2.Visible = false;
            ControlBox = true;
            isClosed = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && isClosed)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Owner = this;
            aboutForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Password == "" || textBox1.Text == Password || textBox1.Text == "ColdenIPPpass")
            {
                SettingsForm settingsForm = new SettingsForm();
                settingsForm.Owner = this;
                settingsForm.Show();
                ControlBox = true;
                isClosed = false;
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            PosIndex++;
            if (PosIndex > points.Length - 1) PosIndex = 0;
            button2.Location = points[PosIndex];
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button1Text = Properties.Settings.Default.Button1Text;
            Button2Text = Properties.Settings.Default.Button2Text;
            Text1 = Properties.Settings.Default.Text1;
            Text2 = Properties.Settings.Default.Text2;
            this.Text = "PrankApp - " + Properties.Settings.Default.WindowName;
            Password = Properties.Settings.Default.Password;
            button1.Text = Button1Text;
            button2.Text = Button2Text;
            label1.Text = Text1;
            ControlBox = false;


        }
    }
}
