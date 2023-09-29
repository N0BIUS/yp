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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Система_управления_библиотекой
{
    public partial class Form1 : Form
    {
        ForSQL SSQL = new ForSQL();
        public Form1()
        {
            InitializeComponent(); CenterToScreen();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string loginin = textBox1.Text;
            string passwordim = textBox2.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string comtext = $"SELECT UserLogin, UserPassword, UserRole FROM User WHERE UserLogin  = '{loginin}' AND UserPassword = '{passwordim}'";
            SqlCommand command = new SqlCommand(comtext, SSQL.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                SSQL.openConnection();
                DataRow[] rows = table.Select();
                SqlDataReader reader = command.ExecuteReader();

                Главное_меню menu = new Главное_меню(int.Parse(rows[0]["UserRole"].ToString()));
                this.Hide();
                menu.ShowDialog();
                this.Show();
                
            }
            else
            {
                MessageBox.Show("Логин или пароль не верны");
            }


            SSQL.closeConnection();
        }

       

       
    }

   
}
