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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
        private string normalize(string source, string key)
            {
                for (int i = key.Length, j = i; i < source.Length; i++, j++)
                {
                    if (j >= key.Length)
                        j = 0;
                    key += key[j];
                }
                return key;
            }
        private string coding(string source, string key)
        {
            string encod = "";
            for (int i = 0; i < source.Length; i++)
                encod += ((char)((int)source[i] + (int)key[i])).ToString();
            return encod;
        }
        private string decoding(string encoded, string key)
        {
            string source = "";
            for (int i = 0; i < encoded.Length; i++)
                source += ((char)((int)encoded[i] - (int)key[i])).ToString();
            return source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Выневвелистроку!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (textBox2.Text == "")
                MessageBox.Show("Выневвелиключ!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            string source = textBox1.Text;
            string key = normalize(source, textBox2.Text);
            string encoded = "";
            encoded = coding(source, key);
            textBox3.Text = encoded;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string source = textBox1.Text;
            string key = normalize(source, textBox2.Text);
            string decoded = "";
            if (textBox3.Text == "")
                MessageBox.Show("Невозможнорасшифроватьпустуюстроку!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            decoded = decoding(source, key);
            textBox4.Text = coding(decoded, key);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true)
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8) //Еслисимвол, введенныйсклавиатуры - нецифра (IsDigit),
                e.Handled = true;// то событие не обрабатывается. ch!=8 (8 - это Backspace)
        }

    }
}
