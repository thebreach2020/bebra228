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
    public partial class Form6 : Form
    {
        public static string Q;

        private const string ABOUT_TEXT = "Разработал: Студент";
        private const string CAPTION_TEXT = "ЛАБОРАТОРНАЯРАБОТА №7. РАЗРАБОТКАПРИЛОЖЕНИЯСНЕСКОЛЬКИМИМОДУЛЯМИ";
        public Form6()
        {
            InitializeComponent();
            Text = CAPTION_TEXT;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(@"Завершитьработупрограммы?", @"Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Q = this.textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = Form7.S;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = Form7.P;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fm = new Form7();
            fm.Show();
        }
    }
}
