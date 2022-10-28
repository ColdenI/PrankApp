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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.WindowName;
            textBox2.Text = Properties.Settings.Default.Text1;
            textBox3.Text = Properties.Settings.Default.Text2;
            textBox4.Text = Properties.Settings.Default.Button1Text;
            textBox5.Text = Properties.Settings.Default.Button2Text;
            textBox6.Text = Properties.Settings.Default.Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.WindowName = textBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Text1 = textBox2.Text;
            Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Text2 = textBox3.Text;
            Properties.Settings.Default.Save();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Button1Text = textBox4.Text;
            Properties.Settings.Default.Save();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Button2Text = textBox5.Text;
            Properties.Settings.Default.Save();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Password = textBox6.Text;
            Properties.Settings.Default.Save();
        }
    }
}
