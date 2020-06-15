using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void weight_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            weight_textBox.Clear();
            height_textBox.Clear();
            age_textBox.Clear();
            result_label.Text = "";
            woman_checkBox.Checked = false;
            man_checkBox.Checked = false;
        }

        private void result_button_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(weight_textBox.Text);
            double height = Convert.ToDouble(height_textBox.Text);
            double age = Convert.ToDouble(age_textBox.Text);
            double result = 0;

                if (woman_checkBox.Checked)
                {
                    result = (9.99 * weight) + (6.25 * height - (4.92 * age)) - 161;
                }
                else
                if (man_checkBox.Checked)
                {
                    result = (9.99 * weight) + (6.25 * height - (4.92 * age)) + 5;
                }
                result_label.Text = result.ToString();
            }

        private void weight_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void height_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void age_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void woman_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(woman_checkBox.Checked == true)
            {
                woman_checkBox.Checked = true;
                man_checkBox.Checked = false;
            }
        }

        private void man_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (man_checkBox.Checked == true)
            {
                man_checkBox.Checked = true;
                woman_checkBox.Checked = false;
            }
        }
    }
}
