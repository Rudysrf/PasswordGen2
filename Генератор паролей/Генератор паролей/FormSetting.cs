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
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        public void Number(ref int a)
        {
            char number = (char)rnd.Next(0, 10);
            a = '0' + number;
        }

        public void BukvaEnglish(ref char a)
        {
            int z = rnd.Next(0, 99);
            if (z < 50) a = (char)rnd.Next(0x0041, 0x005a);
            else a = (char)rnd.Next(0x0061, 0x007a);
        }

        public void BukvaEnglishSymvol(ref char a)
        {
            a = (char)rnd.Next(0x0041, 0x007a);
        }

        public void BukvaRussian(ref char a)
        {
            int z = rnd.Next(0, 99);
            if (z < 50) a = (char)rnd.Next(0x0410, 0x042f);
            else a = (char)rnd.Next(0x0430, 0x044f);
        }

        public void BukvaRussianSymvol(ref char a)
        {
            a=(char)rnd.Next(0x0410,0x044f);
        }
        public void SelectChar(ref int a)
        {
            a = rnd.Next(0, 100);
            if (a < 50) a = 0;
            else a = 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tboxPasswordManual.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = string.Empty;
            char a=' ';
            int b=0;
            char[] mass=new char [int.Parse(cboxLengthPassword.Text)];
            int z = 0;
            
            if(rbtnEnglish.Checked=true)
                if (cboxSymvol.Checked = true)
                {
                    for(int i=0;i<int.Parse(cboxLengthPassword.Text);i++)
                    {
                        for (int v = 0; v < int.Parse(cboxBukv.Text); v++)
                        {
                            z = rnd.Next(0, int.Parse(cboxLengthPassword.Text));
                            if (int.Parse(cboxBukv.Text) > b)
                            {
                                BukvaEnglishSymvol(ref a);
                                if (mass[z] == '\0')
                                    mass[z] = a;
                                b++;
                            }
                        }
                        if (mass[i] == '\0'&&z!=i )
                        {
                            Number(ref b);
                            mass[i] = Convert.ToChar(b);
                        }
                        
                        
                    }
                        Convert.ToString(mass);
                        foreach (char s in mass)
                        {
                            password = password + s;
                        }
                        //password = mass.ToString();
                        tboxPasswordManual.Text = password;
                    
                }
            tboxPasswordManual.Text = password.ToString();
        }
    }
}
