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
    public partial class Form3 : Form
    {
        private const string ABOUT_TEXT = "Разработал: Студент";
        private const string CAPTION_TEXT = "ЛАБОРАТОРНАЯРАБОТА № 4. РАБОТАСДВУМЕРНЫМИМАССИВАМИ";
        private const int ARRAY_SIZE = 5;
        public Form3()
        {
            InitializeComponent();
            Text = CAPTION_TEXT;
        }
        private int[,] _array;

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
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._array = new int[ARRAY_SIZE, ARRAY_SIZE];
            var rnd = new Random();
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                for (int j = 0; j < ARRAY_SIZE; j++)
                {
                    this._array[i, j] = rnd.Next(-50, 50);
                }
            }

            var table = this.CrateDataTableFromArray();

            this.dataGridView1.DataSource = table;
            this.dataGridView1.AutoResizeColumns();
            this.dataGridView1.AutoResizeRows();
        }

        private DataTable CrateDataTableFromArray()
        {
            var table = new DataTable();
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                table.Columns.Add(string.Format("" + i));
            }

            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                var row = table.NewRow();
                for (int j = 0; j < ARRAY_SIZE; j++)
                {
                    row[j] = this._array[i, j];
                }
                table.Rows.Add(row);
            }
            return table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                for (int j = i; j < ARRAY_SIZE; j++)
                {
                    this._array[i, j] = 0;
                }
            }

            var table = this.CrateDataTableFromArray();

            this.dataGridView2.DataSource = table;
            this.dataGridView2.AutoResizeColumns();
            this.dataGridView2.AutoResizeRows();
        }
    }
}
 
