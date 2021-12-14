using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                int P = Convert.ToInt32(textBox1.Text);
                int N = Convert.ToInt32(textBox2.Text);
                int T = Convert.ToInt32(textBox3.Text);
                int D = (T / 100);
                double s = P * (1 + (1 + D / 12) ^ N);
                textBox4.Text = Convert.ToString(s); 
        }
    }
}
