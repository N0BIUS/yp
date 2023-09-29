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
    public partial class Книги_редакция_строки : Form
    {
        string q;
        ForSQL SQL = new ForSQL();
        public Книги_редакция_строки(string idD)
        {
            InitializeComponent();
            CenterToScreen();
            q = $"SELECT * from Книги WHERE [Шифр] = '{idD}'";
        }
        
        private void Книги_редакция_строки_Load(object sender, EventArgs e)
        {
            SQL.openConnection();
            SqlCommand sqlCommand = new SqlCommand(q, SQL.getConnection());

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                id.Text = reader.GetInt32(0).ToString();
                name.Text = reader.GetString(1);
                phone.Text = reader.GetInt32(2).ToString();
                loc.Text = reader.GetString(3);
                maskedTextBox1.Text = reader.GetDateTime(4).ToString();
                priv.Text = reader.GetDecimal(5).ToString();
                pass.Text = reader.GetInt32(6).ToString();
            }

            SQL.closeConnection();
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string h = $"UPDATE Книги SET Название = '{name.Text}', [Код издательства] = '{int.Parse(phone.Text)}', [первый автор] = '{loc.Text}', [год издания] = '{Convert.ToDateTime(maskedTextBox1.Text)}',цена='{Math.Round( decimal.Parse( priv.Text))}', [кол-во] = '{int.Parse(pass.Text)}' WHERE[Шифр]='{id.Text}' ";
            SQL.SQLcommand(h);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
