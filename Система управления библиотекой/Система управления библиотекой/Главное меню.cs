using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Система_управления_библиотекой
{
    public partial class Главное_меню : Form
    {
        
        public Главное_меню(int priv)
        {
            InitializeComponent(); CenterToScreen();
            if (priv ==2 ) 
            {
                groupBox1.Visible = false;
            }if (priv ==3) 
            {
                groupBox1.Visible = false;
                button2.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Каталог_книг к = new Каталог_книг();
            к.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Редакция р = new Редакция();
            р.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Выдача_добавить В = new Выдача_добавить();
            this.Hide();
            В.ShowDialog();
            this.Show();
        }
    }
}
