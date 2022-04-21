using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Генератор_паролей
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        public void Number(ref int a)
        {
            a = rnd.Next(0, 9);
        }

        public void Bukva(ref char a)
        {
            int z = rnd.Next(0, 99);
            if (z < 50) a = (char)rnd.Next(0x0041, 0x005a);
            else a = (char)rnd.Next(0x0061, 0x007a);
        }

        public void SelectChar(ref int a)
        {
            a=rnd.Next(0,100);
            if (a < 50) a = 0;
            else a = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            char b = ' ';
            int c=0;
            string password = string.Empty;

            for (int i = 0; i < int.Parse(cboxLengthPassword.Text); i++)
            {
                SelectChar(ref a);
                if (a == 0)
                {
                    Number(ref c);
                    password = password + c;

                }
                else
                {
                    Bukva(ref b);
                    password = password + b;
                }
            }

            tboxPassword.Text = password.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int LengthPassword = rnd.Next(6, 20);

            int a = 0;
            char b = ' ';
            int c = 0;
            string password = string.Empty;

            for (int i = 0; i < LengthPassword; i++)
            {
                SelectChar(ref a);
                if (a == 0)
                {
                    Number(ref c);
                    password = password + c;

                }
                else
                {
                    Bukva(ref b);
                    password = password + b;
                }
            }

            tboxPasswordGenAuto.Text = password.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxPassword.Clear();
            tboxPasswordGenAuto.Clear();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FormSetting fs = new FormSetting();
            fs.ShowDialog();
        }
    }
}
