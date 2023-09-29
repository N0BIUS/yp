using sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Система_управления_библиотекой
{
    public partial class Читатели_редакция_строки : Form
    {
        public string q;
        public Читатели_редакция_строки(string idD)
        {
            InitializeComponent();
            CenterToScreen();
            q = $"SELECT * from читатели WHERE [Код читателя] = '{idD}'";
        }
      
       
        ForSQL SQL = new ForSQL();

       
        

        private void button1_Click(object sender, EventArgs e)
        {
            string h = $"UPDATE  читатели SET ФИО = '{name.Text}', телефон = '{phone.Text}', адрес = '{loc.Text}' WHERE[Код читателя]='{id.Text}' ";
            SQL.SQLcommand(h);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Читатели_редакция_строки_Load(object sender, EventArgs e)
        {

            SQL.openConnection();
            SqlCommand sqlCommand = new SqlCommand(q, SQL.getConnection());

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                id.Text = reader.GetString(0);
                name.Text = reader.GetString(1);
                phone.Text = reader.GetString(2);
                loc.Text = reader.GetString(3);

            }

            SQL.closeConnection();
            reader.Close();
        }
    }
}
