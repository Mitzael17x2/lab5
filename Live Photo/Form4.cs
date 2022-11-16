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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.FormClosing += toolStripButton3_Click;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "live_PhotoDataSet.Registrations". При необходимости она может быть перемещена или удалена.
            this.registrationsTableAdapter.Fill(this.live_PhotoDataSet.Registrations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "live_PhotoDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.live_PhotoDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "live_PhotoDataSet.Employees_registrations". При необходимости она может быть перемещена или удалена.
            this.employees_registrationsTableAdapter.Fill(this.live_PhotoDataSet.Employees_registrations);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            employeesregistrationsBindingSource.EndEdit();
            employees_registrationsTableAdapter.Update(live_PhotoDataSet);
            MessageBox.Show("Данные успешно сохранены");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AboutBox1().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            this.Hide();
            f3.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
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
