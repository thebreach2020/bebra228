using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bebra228
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long a, b, t;
            a = long.Parse(textBox1.Text);
            try
            {
                a = int.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введитечисло.");
                textBox1.Select();
                return;
            }
            b = long.Parse(textBox2.Text);
            while (b > 0)
            {
                t = a % b;
                a = b;
                b = t;
            }
            textBox3.Text = a.ToString();


            //  MessageBox.Show("Наибольшийобщийделительдвухчисел, равен " + a + "  ");

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
