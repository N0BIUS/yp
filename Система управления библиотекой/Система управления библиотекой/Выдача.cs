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
    public partial class Выдача : Form
    {
        public Выдача()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public string queryString = $"SELECT * from Выдача";
        private void Выдача_Load(object sender, EventArgs e)
        {
           
            RefreshDataGridData1(dataGridView1, queryString);
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
                dataRecord.GetString(0),
                dataRecord.GetInt32(1),
                dataRecord.GetDateTime(2),
                dataRecord.GetString(3),
                dataRecord.GetString(4),
                dataRecord.GetString(5)
                
                );

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Выдача_добавить в = new Выдача_добавить();
            this.Hide();
            в.ShowDialog();
            RefreshDataGridData1(dataGridView1, queryString);
            this.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                выдача_редактирование_строки с = new выдача_редактирование_строки(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString());
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
            string quString = $"Delete from Выдача WHERE [Код читателя] = '{textBox5.Text}' And Шифр ='{int.Parse(textBox1.Text)}' ";
            SQL.SQLcommand(quString);
            RefreshDataGridData1(dataGridView1, queryString);
        }
    }
}
