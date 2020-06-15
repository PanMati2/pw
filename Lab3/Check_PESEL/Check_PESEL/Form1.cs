using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_PESEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pesel.MaxLength = 11;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pesel.Text.Length > 11 || pesel.Text.Length < 11)
            {
                result.Text = "Pesel musi mieć 11 znaków!";
            }
            else
            {
                int[] mnoznik = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
                int sum = 0;
                string peselik = pesel.Text;
                string temp = peselik.Substring(10, 1);


                for (int i=0; i<mnoznik.Length; i++)
                {
                    sum += (mnoznik[i] * peselik[i]);
                }
                sum = sum - 2112;
                result.Text = sum.ToString();
                int reszta = sum % 10;
                if(reszta == 0)
                {
                    result.Text = "Pesel jest poprawny!";
                }
                else
                {
                    int wynik = 10 - reszta;
                    if(wynik == Convert.ToInt32(temp))
                    {
                        result.Text = "Pesel jest poprawny!";
                    }
                    else
                    {
                        result.Text = "Błędny pesel!";
                    }
                }
               
            }
        }

        private void pesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
