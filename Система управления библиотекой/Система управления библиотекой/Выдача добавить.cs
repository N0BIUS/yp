using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class Выдача_добавить : Form
    {
        public Выдача_добавить()
        {
            InitializeComponent();
            CenterToScreen();
        }
     ForSQL SQL = new ForSQL();
        private void button1_Click(object sender, EventArgs e)
        {
             try
             {
            SQL.openConnection();
                  string name = this.tid.Text;
              int id = int.Parse(this.shif.Text);
                DateTime loc = DateTime.Parse(this.maskedTextBox1.Text);
                string phone = this.рос.Text;
                string d = kod.Text;
                string m = рос2.Text;
                

                string addWuery = $"insert into Выдача ([Код читателя],Шифр,дата,[роспись читателя],Выдана,[роспись сотрудника])" + $"values ('{id}','{name}','{loc}','{phone}','{d}','{m}')";
                SqlCommand command = new SqlCommand(addWuery, SQL.getConnection());
                command.ExecuteNonQuery();
                SQL.closeConnection();
                this.Close();


           }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }
    }
}
