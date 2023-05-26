using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mashine
{
    public partial class Form1 :Form
    {
     
        Qp tol;
        public Form1()
        {
            InitializeComponent();
            tol = new Qp(listBox1);
        }

        private void Form1_Load (object sender, EventArgs e)
        {

        }

        private void label1_Click (object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tol.marka = textBox5.Text;tol.mile = int.Parse(textBox1.Text); tol.fuel = double.Parse(textBox2.Text); tol.p = int.Parse(textBox3.Text);
                if (tol.scn == true)
                {
                    tol.Add();
                    MessageBox.Show("Данные добавлены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBox1.Items.Clear();
                    tol.GetAllList();
                }
            }
            catch { MessageBox.Show("Ошибка: возможно не заполнены столбцы или не тем типом данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                tol.Remove(textBox4.Text);
                listBox1.Items.Clear();
                tol.GetAllList();
            }
            else
            {
                MessageBox.Show("Пуская строка имени для удаления, повторите ввод", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
