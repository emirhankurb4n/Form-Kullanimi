using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter tuşu çalışıyor.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esc tuşu çalışıyor.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.ControlBox == true)
            {
                this.ControlBox = false;
            }
            else
            {
                this.ControlBox = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 formB = new Form2();
            formB.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 formB = new Form2();
            formB.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("FormA yükleniyor.");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("FormA kapandı.");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("FormA kapanıyor.");
        }
    }
}
