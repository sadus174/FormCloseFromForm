using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Form2 form2; //добавляем поле класса дочерней формы


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //кнопка "Открыть"
        {
            form2 = new Form2();
            form2.Show(); //открываем
        }
        private void button2_Click(object sender, EventArgs e) // кнопка "Закрыть"
        {
            if (form2 != null) //если ссылка не пустая
            {
                form2.Close(); //закрываем
            }
        }
    }
    
}
