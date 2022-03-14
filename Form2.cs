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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("FormB kapandı.");
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FormB click olayı çalışıyor.");
        }
    }
}
