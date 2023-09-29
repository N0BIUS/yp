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
    public partial class Каталог_книг : Form
    {
         ForSQL SQL = new ForSQL();
        public Каталог_книг()
        {
            InitializeComponent();
            RefreshDataGridData1(dataGridView1, $"SELECT * from Книги");
            CenterToScreen();
        }
      
        private void Каталог_книг_Load(object sender, EventArgs e)
        {
            
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
                dataRecord.GetValue(5),
                dataRecord.GetInt32(6)
                );

        }
    }
}
