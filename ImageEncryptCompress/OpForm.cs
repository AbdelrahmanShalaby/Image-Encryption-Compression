using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ImageQuantization;

namespace ImageEncryptCompress
{
    public partial class OpForm : Form
    {
        int Key;
        public OpForm()
        {
           
            InitializeComponent();
            ImageOperations.DisplayImage(Program.OriginalImage, pictureBox1);
        }
        private void OpForm_Load(object sender, EventArgs e)
        {

        }
        private void OpForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Tap = Int32.Parse(textBox2.Text);
            string Seed = textBox4.Text.ToString();
            Program.GetKey(Seed,Tap);
            ImageOperations.DisplayImage(Program.OriginalImage, pictureBox1);

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int Tap = Int32.Parse(textBox2.Text);
            string Seed = textBox4.Text.ToString();
            Program.GetKey(Seed, Tap);
            ImageOperations.DisplayImage(Program.OriginalImage, pictureBox1);
        }
    }
}
