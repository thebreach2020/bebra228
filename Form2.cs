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
    public partial class Form2 : Form
    {
        private const string ABOUT_TEXT = "Разработал: Студент";
        private const string CAPTION_TEXT = "ЛАБОРАТОРНАЯРАБОТА №3. РАБОТАСОДНОМЕРНЫМИМАССИВАМИ";
        public Form2()
        {
            InitializeComponent();
            Text = CAPTION_TEXT;
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CAPTION_TEXT + Environment.NewLine + ABOUT_TEXT, @"Опрограмме", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(@"Завершитьработупрограммы?", @"Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void Clear()
        {
            this.richTextBox1.Clear();
            this.richTextBox2.Clear();
            this.listBox1.Items.Clear();
            this.comboBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs args)
        {
            this.Clear();
            var count = int.Parse(this.textBox1.Text);
            var items = new int[count];
            var rnd = new Random();

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = rnd.Next(-20, 20);
            }

            this.richTextBox1.Text = string.Join(Environment.NewLine, items);
            this.richTextBox2.Text = string.Join(Environment.NewLine, items.Where(e => e > 0)); this.listBox1.Items.AddRange(items.Where(e => e < 0).Select(e => (object)e).ToArray());
            this.comboBox1.Items.AddRange(items.Where(e => e % 2 == 0).Select(e => (object)e).ToArray());
            this.comboBox1.SelectedIndex = 0;
        }
    }
}

