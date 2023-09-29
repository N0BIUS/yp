using sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Система_управления_библиотекой
{
    public partial class Читатели_редакция_ : Form
    {
        ForSQL SQL = new ForSQL();
        public Читатели_редакция_()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public string queryString = $"SELECT * from читатели";

        private void Читатели_редакция__Load(object sender, EventArgs e)
        {
            
            RefreshDataGridData1(dataGridView1, queryString);
        }
        private void RefreshDataGridData1(DataGridView dataGridView,  string queryString)
        {
            dataGridView.Rows.Clear();
            SqlCommand sqlCommand = new SqlCommand(queryString, SQL.getConnection());
            SQL.openConnection();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
                ReadSingleRowData1(dataGridView, reader);
            reader.Close();
        }

        private void ReadSingleRowData1(DataGridView dataGridView, IDataRecord dataRecord)
        {

            dataGridView.Rows.Add(
                dataRecord.GetString(0),
                dataRecord.GetString(1),
                dataRecord.GetString(2),
                dataRecord.GetString(3)
                );

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.textBox1.Text;
                string name = this.textBox2.Text;
                string loc = this.textBox3.Text;
                string phone = this.textBox4.Text;
          
                string addWuery = $"insert into читатели ([Код читателя],ФИО,телефон,адрес)" + $"values ('{id}','{name}','{phone}','{loc}')";
                SqlCommand command = new SqlCommand(addWuery, SQL.getConnection());
                command.ExecuteNonQuery();
                RefreshDataGridData1(dataGridView1, queryString);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Читатели_редакция_строки с = new Читатели_редакция_строки(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                this.Hide();
                с.ShowDialog();
                this.Show();
                RefreshDataGridData1(dataGridView1, queryString);
            }
            catch
            {
                MessageBox.Show("Пустые данные");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string quString = $"Delete from читатели where [Код читателя] = '{textBox5.Text}' ";
            SQL.SQLcommand(quString);
            RefreshDataGridData1(dataGridView1, queryString);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
