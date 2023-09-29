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
    public partial class Сотрудники : Form
    {
        public Сотрудники()
        {
            InitializeComponent();
            CenterToScreen();
        }
        ForSQL SQL = new ForSQL();
        public string queryString = $"SELECT * from Сотрудники";
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
                dataRecord.GetString(0),
                dataRecord.GetString(1),
                dataRecord.GetString(2),
                dataRecord.GetString(3),
               dataRecord.GetInt32(4), 
               dataRecord.GetString(5)
              
                );

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id= this.id.Text;
                string name = this.name.Text;
                string loc = this.loc.Text;
                string phone = this.phone.Text;
                int priv = int.Parse(this.priv.Text);
                
                string pass = this.pass.Text;
                string addWuery = $"insert into Сотрудники ([Код сотрудника],ФИО,телефон,адрес,Должность,Password)" + $"values ('{id}','{name}','{phone}','{loc}','{priv}','{pass}')";
                SqlCommand command = new SqlCommand(addWuery, SQL.getConnection());
                command.ExecuteNonQuery();
                RefreshDataGridData1(dataGridView1, queryString);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            string quString = $"Delete from Сотрудники where [Код сотрудника] = '{textBox5.Text}' ";
            SQL.SQLcommand(quString);
            RefreshDataGridData1(dataGridView1, queryString);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Сотрудники_редакция_строки с = new Сотрудники_редакция_строки(dataGridView1.CurrentRow.Cells[0].Value.ToString());
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
