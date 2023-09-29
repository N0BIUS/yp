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
    public partial class Издательства : Form
    {
        public Издательства()
        {
            InitializeComponent();
            CenterToScreen();
        }
        ForSQL SQL = new ForSQL();

     
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
                dataRecord.GetString(2)
                );

        }
        public string queryString = $"SELECT * from Издательства";
        private void Издательства_Load(object sender, EventArgs e)
        {
           
            RefreshDataGridData1(dataGridView1, queryString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.textBox1.Text);
                string name = this.textBox2.Text;
                string loc =this.textBox3.Text;
            

                string addWuery = $"insert into Издательства ([Код издательства],Наименование,город)" + $"values ('{id}','{name}','{loc}')";
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
                Издательства_редакция_строки с = new Издательства_редакция_строки(dataGridView1.CurrentRow.Cells[0].Value.ToString());
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
            string quString = $"Delete from Издательства where [Код издательства] = '{textBox5.Text}' ";
            SQL.SQLcommand(quString);
            RefreshDataGridData1(dataGridView1, queryString);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
