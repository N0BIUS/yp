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
    public partial class Книги : Form
    {
        public Книги()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Книги_Load(object sender, EventArgs e)
        {
   
            RefreshDataGridData1(dataGridView1, queryString);
        }
        ForSQL SQL = new ForSQL();
        public string queryString = $"SELECT * from Книги";
        private void Сотрудники_Load(object sender, EventArgs e)
        {
        
            RefreshDataGridData1(dataGridView1, queryString);
        }
        private void RefreshDataGridData1(DataGridView dataGridView, string queryString)
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
                dataRecord.GetInt32(0),
                dataRecord.GetString(1),
                dataRecord.GetInt32(2),
                dataRecord.GetString(3),
                dataRecord.GetDateTime(4),
                dataRecord.GetDecimal(5),
                 dataRecord.GetInt32(6)
               );

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.textBox1.Text);
                string name = this.textBox2.Text;
                int loc = int.Parse(this.textBox3.Text);
                string phone = this.textBox4.Text;
                DateTime d = DateTime.Parse(maskedTextBox1.Text);
                decimal m = decimal.Parse(textBox7.Text);
                int k = int.Parse(textBox6.Text);

                string addWuery = $"insert into Книги (Шифр,Название,[Код издательства],[первый автор],[год издания],цена,[кол-во])" + $"values ('{id}','{name}','{phone}','{loc}','{d}','{m}','{k}')";
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
               Книги_редакция_строки с = new Книги_редакция_строки(dataGridView1.CurrentRow.Cells[0].Value.ToString());
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
            string quString = $"Delete from Книги where [Шифр] = '{textBox5.Text}' ";
            SQL.SQLcommand(quString);
            RefreshDataGridData1(dataGridView1, queryString);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
