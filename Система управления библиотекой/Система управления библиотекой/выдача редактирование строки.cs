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
    public partial class выдача_редактирование_строки : Form
    {
        string q;
        public выдача_редактирование_строки(string idD,string SHIF)
        {
            InitializeComponent();
            CenterToScreen();
            q = $"SELECT * from Выдача WHERE [Код читателя] = '{idD}' And Шифр ='{SHIF}'";
        }
        ForSQL SQL = new ForSQL();
        private void выдача_редактирование_строки_Load(object sender, EventArgs e)
        {
            SQL.openConnection();
            SqlCommand sqlCommand = new SqlCommand(q, SQL.getConnection());

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                id.Text = reader.GetString(0);
                name.Text = reader.GetInt32(1).ToString();
                maskedTextBox1.Text = reader.GetDateTime(2).ToString();
                loc.Text = reader.GetString(3);
                priv.Text = reader.GetString(4);
                pass.Text = reader.GetString(5);
            }

            SQL.closeConnection();
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string h = $"UPDATE  Выдача SET дата = '{Convert.ToDateTime(maskedTextBox1.Text)}', [роспись читателя] = '{loc.Text}', Выдана = '{priv.Text}',  [роспись сотрудника] = '{pass.Text}'WHERE [Код читателя] = '{id.Text}' And Шифр ='{int.Parse( name.Text)}' ";
            SQL.SQLcommand(h);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
