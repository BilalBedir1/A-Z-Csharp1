using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_Kullanımları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Baran";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Nikola";
            label7.Text = "Tesla";
            label8.Text = "Engineer";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Computer Engineer";
            label9.Text = textBox1.Text;
        }
    }
}
