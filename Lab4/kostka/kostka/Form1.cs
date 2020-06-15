using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostka
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

        private void key_r(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'r')
            {
                Random rnd = new Random();
                label1.Text = rnd.Next(1, 7).ToString();
            }
            else
            {
                MessageBox.Show("Aby wylosować kolejna liczbę należy kliknąć klawisz R");
            }
        }

        private void doSchowka(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(label1.Text);
        }
    }
}
