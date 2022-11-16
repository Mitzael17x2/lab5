using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Live_Photo
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.FormClosing += toolStripButton3_Click;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "live_PhotoDataSet.Registrations". При необходимости она может быть перемещена или удалена.
            this.registrationsTableAdapter.Fill(this.live_PhotoDataSet.Registrations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "live_PhotoDataSet.Chromakey". При необходимости она может быть перемещена или удалена.
            this.chromakeyTableAdapter.Fill(this.live_PhotoDataSet.Chromakey);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "live_PhotoDataSet.Printers". При необходимости она может быть перемещена или удалена.
            this.printersTableAdapter.Fill(this.live_PhotoDataSet.Printers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "live_PhotoDataSet.Clothes". При необходимости она может быть перемещена или удалена.
            this.clothesTableAdapter.Fill(this.live_PhotoDataSet.Clothes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "live_PhotoDataSet.Searchlights". При необходимости она может быть перемещена или удалена.
            this.searchlightsTableAdapter.Fill(this.live_PhotoDataSet.Searchlights);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "live_PhotoDataSet.Cameras". При необходимости она может быть перемещена или удалена.
            this.camerasTableAdapter.Fill(this.live_PhotoDataSet.Cameras);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "live_PhotoDataSet.Facilites_and_clothes". При необходимости она может быть перемещена или удалена.
            this.facilites_and_clothesTableAdapter.Fill(this.live_PhotoDataSet.Facilites_and_clothes);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            facilitesandclothesBindingSource.EndEdit();

            try
            {
                facilites_and_clothesTableAdapter.Update(live_PhotoDataSet);
                MessageBox.Show("Данные успешно сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения. Первичный ключ используется в другой таблице ");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AboutBox1().Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            new AboutBox1().Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form clothes = new clothes();
            clothes.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            Form f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form chromakey = new chromakey();
            chromakey.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new searchlight().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Camera().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Printer().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
