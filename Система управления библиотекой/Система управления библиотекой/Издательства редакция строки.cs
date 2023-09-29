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
    public partial class Издательства_редакция_строки : Form
    {
        string q;
        public Издательства_редакция_строки(string idD)
        {
            InitializeComponent();
            CenterToScreen();
            q = $"SELECT * from Издательства WHERE [Код издательства] = '{idD}'";
        }
        ForSQL SQL = new ForSQL();
        private void button1_Click(object sender, EventArgs e)
        {
            string h = $"UPDATE  Издательства SET Наименование = '{name.Text}', город = '{phone.Text}' WHERE[Код издательства]='{int.Parse(id.Text)}' ";
            SQL.SQLcommand(h);
            this.Close();
        }

        private void Издательства_редакция_строки_Load(object sender, EventArgs e)
        {
            SQL.openConnection();
            SqlCommand sqlCommand = new SqlCommand(q, SQL.getConnection());

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                id.Text = reader.GetInt32(0).ToString();
                name.Text = reader.GetString(1);
                phone.Text = reader.GetString(2);
               
            }

            SQL.closeConnection();
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
