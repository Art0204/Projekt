using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artak20
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

        private void button1_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked)
            { int oplata = t * 9*12; textBox2.Text = Convert.ToString(oplata);}
            if (radioButton2.Checked)
            { int oplata = t * 12*15; textBox2.Text = Convert.ToString(oplata); }
            if (radioButton3.Checked)
            { int oplata = t * 18 * 24; textBox2.Text = Convert.ToString(oplata); }
        }
            

        
    }
}
