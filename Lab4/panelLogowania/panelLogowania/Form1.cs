using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panelLogowania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if((login.Text == "admin" && password.Text == "password") || (login.Text == "admin2" && password.Text == "password2"))
            {
                MessageBox.Show("Zalogowałeś się pomyślnie!");
            }
           else
            {
                MessageBox.Show("Błędny login lub hasło!");
            }
        }
    }
}
