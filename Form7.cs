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
    public partial class Form7 : Form
    {
        public static string S;
        public static string P;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            S = this.textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            P = this.textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = Form1.Q;
        }
    }
}
