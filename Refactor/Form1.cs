using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResultBtn_Click(object sender, EventArgs e)
        {
            try
            {

                int a = Convert.ToInt32(StrTxb1.Text);
                int b = Convert.ToInt32(StrTxb2.Text);
                int c = Convert.ToInt32(StrTxb3.Text);
                int lose;
                lose = 0;

                if (a > b && a > b)
                    if (b + c < a)
                    {
                        MessageBox.Show(
                "Сумма двух сторон должна превышать длину самой длинной стороны",
                "Вы ввели неверное значение",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error); lose = 1;
                    }
                if (b > a && b > c)
                    if (a + c < b)
                    {
                        MessageBox.Show(
                "Сумма двух сторон должна превышать длину самой длинной стороны",
                "Вы ввели неверное значение",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error); lose = 1;
                    }
                if (c > b && c > a)
                    if (b + a < c)
                    {
                        MessageBox.Show(
                "Сумма двух сторон должна превышать длину самой длинной стороны",
                "Вы ввели неверное значение",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error); lose = 1;
                    }

                if (a == 0 || b == 0 || b == 0) //Защита от ввода нулей в любой Textbox
                {
                    MessageBox.Show(
                "А вот нули тут вводить нельзя",
                "Вы ввели неверное значение",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error); lose = 1;
                }
                if (lose == 1)
                {
                    label3.Text = "Повторите ввод уже с другими данными";
                    label3.ForeColor = Color.Red;
                    StrTxb1.Clear();
                    StrTxb2.Clear();
                    StrTxb3.Clear();
                }
                else if (a == b && b == c)
                {
                    label3.Text = "Равносторонний";
                    label3.ForeColor = Color.Blue;
                }
                else if (a == b || b == c || a == c)
                {
                    label3.Text = "Равнобедренный";
                    label3.ForeColor = Color.Blue;
                }
                else if ((a != b) && (b != c) && (a != c))
                {
                    label3.Text = "Разносторонний";
                    label3.ForeColor = Color.Blue;
                }

            }
            catch
            {
                MessageBox.Show(
               "Неправильно ввели! Повторите попытку",
               "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
               );
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trTxb1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void StrTxb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void StrTxb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void StrTxb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StrTxb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void StrTxb3_TextChanged(object sender, EventArgs e)
        {

        }

        private void StrTxb1_Enter(object sender, EventArgs e)
        {
            if (StrTxb1.Text == "Сюда первую сторону")
            {
                StrTxb1.Text = "";
                StrTxb1.ForeColor = Color.Black;
            }
        }

        private void StrTxb2_Enter(object sender, EventArgs e)
        {
            if (StrTxb2.Text == "Сюда вторую сторону")
            {
                StrTxb2.Text = "";
                StrTxb2.ForeColor = Color.Black;
            }
        }

        private void StrTxb3_Enter(object sender, EventArgs e)
        {
            if (StrTxb3.Text == "Ну и как без третьей")
            {
                StrTxb3.Text = "";
                StrTxb3.ForeColor = Color.Black;
            }
        }
    }
}
