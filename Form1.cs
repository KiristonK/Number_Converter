using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convert_Button_Click(object sender, EventArgs e)
        {
            if (decnum.Text == "")
            {
                MessageBox.Show("Enter number !", "Error!");
            }
            else
            {
                if (int.Parse(decnum.Text) < 0)
                {
                    textBox2.Text = "-" + Decbin(decnum, 2);
                    textBox3.Text = "-" + Decbin(decnum, 3);
                    textBox4.Text = "-" + Decbin(decnum, 4);
                    textBox5.Text = "-" + Decbin(decnum, 5);
                    textBox6.Text = "-" + Decbin(decnum, 6);
                    textBox7.Text = "-" + Decbin(decnum, 7);
                    textBox8.Text = "-" + Decbin(decnum, 8);
                    textBox9.Text = "-" + Decbin(decnum, 9);
                    textBox10.Text = decnum.Text;
                    textBox11.Text = "-" + Dechigh(decnum, 11);
                    textBox12.Text = "-" + Dechigh(decnum, 12);
                    textBox13.Text = "-" + Dechigh(decnum, 13);
                    textBox14.Text = "-" + Dechigh(decnum, 14);
                    textBox15.Text = "-" + Dechigh(decnum, 15);
                    textBox16.Text = "-" + Dechigh(decnum, 16);
                }
                else
                {
                    textBox2.Text = Decbin(decnum, 2);
                    textBox3.Text = Decbin(decnum, 3);
                    textBox4.Text = Decbin(decnum, 4);
                    textBox5.Text = Decbin(decnum, 5);
                    textBox6.Text = Decbin(decnum, 6);
                    textBox7.Text = Decbin(decnum, 7);
                    textBox8.Text = Decbin(decnum, 8);
                    textBox9.Text = Decbin(decnum, 9);
                    textBox10.Text = decnum.Text;
                    textBox11.Text = Dechigh(decnum, 11);
                    textBox12.Text = Dechigh(decnum, 12);
                    textBox13.Text = Dechigh(decnum, 13);
                    textBox14.Text = Dechigh(decnum, 14);
                    textBox15.Text = Dechigh(decnum, 15);
                    textBox16.Text = Dechigh(decnum, 16);
                }
            }
        }

        private void decnum_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Convert_Button_Click(sender, e);
                    // Convert_Button.Focus();
                    //перехватываем нажатие клавиши, удаляется звук
                    e.Handled = true;
                }
        }

        private string Dechigh(TextBox decnum, int sistema)
        {
            const int S = 100;
            int b, a;
            string g = "";
            int[] bin = new int[S];
            int[] bin2 = new int[S];
            char[] dechigh = new char[S];
            int i = 0;
            if (int.Parse(decnum.Text) < 0)
            {
                a = int.Parse(decnum.Text);
                a *= -1;
            }
            else
            {
                a = int.Parse(decnum.Text);
            }
            int k;
            do
            {
                b = a;
                a /= sistema;
                b -= a * sistema;
                bin[i] = b;
                i++;
            } while (a != 0);
            k = i - 1;
            for (int j = 0; j < i; j++)
            {

                bin2[j] = bin[k];
                if (bin2[j] < 10)
                    g += bin2[j].ToString();
                if (bin2[j] >= 10)
                {
                    switch (bin2[j])
                    {
                        case 10:

                            dechigh[0] = 'A';
                            g += dechigh[0].ToString();
                            break;
                        case 11:

                            dechigh[1] = 'B';
                            g += dechigh[1].ToString();
                            break;
                        case 12:

                            dechigh[2] = 'C';
                            g += dechigh[2].ToString();
                            break;
                        case 13:

                            dechigh[3] = 'D';
                            g += dechigh[3].ToString();
                            break;
                        case 14:

                            dechigh[4] = 'E';
                            g += dechigh[4].ToString();
                            break;
                        case 15:

                            dechigh[5] = 'F';
                            g += dechigh[5].ToString();
                            break;
                    }
                }
                k--;
            }
            return g;
        }

        private string Decbin(TextBox decnum, int sistem)
        {
            const int S = 100;
            int b, a;
            int[] bin = new int[S];
            int[] bin2 = new int[S];
            int i = 0;
            string p = "";
            if (int.Parse(decnum.Text) < 0)
            {
                a = int.Parse(decnum.Text);
                a *= -1;
            }
            else
            {
                a = int.Parse(decnum.Text);
            }
            do
            {
                b = a;
                a /= sistem;
                b -= a * sistem;
                bin[i] = b;
                i++;
            } while (a != 0);

            int k = i - 1;

            for (int j = 0; j < i; j++)
            {
                bin2[j] = bin[k];
                k--;
            }

            for (int g = 0; g < i; g++)
            {
                p += bin2[g].ToString();
            }
            return p;
        }

 
    }
}
