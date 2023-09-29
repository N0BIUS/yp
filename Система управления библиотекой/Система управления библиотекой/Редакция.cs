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
    public partial class Редакция : Form
    {
        public Редакция()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Читатели_редакция_ ч = new Читатели_редакция_();
            ч.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Издательства E = new Издательства();
            E.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Сотрудники с = new Сотрудники();
            с.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Книги к = new Книги();
            к.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Выдача в = new Выдача();
            в.ShowDialog();
        }
    }
}
