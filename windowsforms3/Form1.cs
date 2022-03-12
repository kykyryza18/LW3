using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsforms3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, m,j;
            x = Convert.ToDouble(textBox1.Text);
            m = Convert.ToDouble(textBox2.Text);

            if (m<x && m>-1)
            {
                textBox3.Clear();
                j = Math.Sin(5 * Math.Pow(x, 2) + 3 * m * Math.Abs(Math.Pow(x, 2)));
                textBox3.Text += "J = " + j.ToString();
            }
            else if (x>m)
            {
                textBox3.Clear();
                j = Math.Cos(3 * Math.Pow(x, 2) + 5 * m * Math.Abs(Math.Pow(x, 2)));
                textBox3.Text += "J = " + j.ToString();
            }
            else if (x == m)
            {
                textBox3.Clear();
                j = Math.Pow(Math.Pow(x, 2) +m, 2);
                textBox3.Text += "J = " + j.ToString();
            }
        }
    }
}
