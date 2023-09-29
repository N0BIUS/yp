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
    public partial class Сотрудники_редакция_строки : Form
    {
        public string q;
        public Сотрудники_редакция_строки(string idD)
        {
            InitializeComponent();
            CenterToScreen();
            q = $"SELECT * from Сотрудники WHERE [Код сотрудника] = '{idD}'";
        }
        ForSQL SQL = new ForSQL();

        private void Сотрудники_редакция_строки_Load(object sender, EventArgs e)
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
               priv.Text = reader.GetInt32(4).ToString(); 
                pass.Text = reader.GetString(5); 
            }

            SQL.closeConnection();
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string h = $"UPDATE  Сотрудники SET ФИО = '{name.Text}', телефон = '{phone.Text}', адрес = '{loc.Text}',  Должность = '{int.Parse(priv.Text)}', Password = '{pass.Text}'WHERE[Код сотрудника]='{id.Text}' ";
            SQL.SQLcommand(h);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
