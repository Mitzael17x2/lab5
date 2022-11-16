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
    public partial class Form2 : Form
    {
        public Form2()
        {
            this.FormClosing += Form_FormClosing;
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "live_PhotoDataSet.Document_hirinng". При необходимости она может быть перемещена или удалена.
            this.document_hirinngTableAdapter.Fill(this.live_PhotoDataSet.Document_hirinng);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "live_PhotoDataSet.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.live_PhotoDataSet.Post);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "live_PhotoDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.live_PhotoDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "live_PhotoDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.live_PhotoDataSet.Client);

        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

             employeesBindingSource.EndEdit();
            try
            {
                employeesTableAdapter.Update(live_PhotoDataSet);
                MessageBox.Show("Данные успешно сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения. Первичный ключ используется в другой таблице ");
            }
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AboutBox1().Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            new AboutBox1().Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form3();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Documents().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Post().Show();
        }

        private void button6_Click(object sender, EventArgs e)
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
    }
}
