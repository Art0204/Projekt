using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artak02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int p = Convert.ToInt32(textBox1.Text;);

         
            int TT = Convert.ToInt32(textBox2.Text);
            int TTT = TT / 12;
            int t = TTT + 1;

            
            int n = Convert.ToInt32(textBox3.Text);

            int Sum = p + p * n * t / 100;
            textBox4.Text = Convert.ToString(Sum);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
