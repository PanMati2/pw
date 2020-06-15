using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lab5_bibloteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bibloteka;";
            string query = "INSERT INTO ksiazki(tytul, autor, rok_wydania, gatunek, ilosc) VALUES('" + this.title.Text + "','" + this.author.Text + "','" + this.date.Text + "','" + this.genre.Text + "','" + this.amount.Text + "');";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                title.Clear();
                author.Clear();
                date.Clear();
                genre.Clear();
                amount.Clear();

                databaseConnection.Open();
                int i = commandDatabase.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Dodano nowy rekord!");
                }
                else
                {
                    MessageBox.Show("Coś poszło nie tak");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bibloteka;";
            if(availability.Checked)
            {
                string query = "SELECT * FROM ksiazki WHERE ilosc>0";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;

                try
                {
                    databaseConnection.Open();

                    reader = commandDatabase.ExecuteReader();

                    if (reader.HasRows)
                    {
                        listBox1.Items.Clear();
                        MessageBox.Show("Udało się!");
                        while (reader.Read())
                        {
                            string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                            listBox1.Items.Add("ID: " + row[0] + " Tytuł: " + row[1] + " Autor: " + row[2] + " Rok Wydania: " + row[3] + " Gatunek: " + row[4] + " Ilość: " + row[5]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Brak rekordów!");
                    }
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string query = "SELECT * FROM ksiazki";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;

                try
                {
                    databaseConnection.Open();

                    reader = commandDatabase.ExecuteReader();

                    if (reader.HasRows)
                    {
                        listBox1.Items.Clear();
                        MessageBox.Show("Udało się!");
                        while (reader.Read())
                        {
                            string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                            listBox1.Items.Add("ID: " + row[0] + " Tytuł: " + row[1] + " Autor: " + row[2] + " Rok Wydania: " + row[3] + " Gatunek: " + row[4] + " Ilość: " + row[5]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Brak rekordów!");
                    }
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bibloteka;";
            string query = "DELETE FROM ksiazki where id='" + this.delete.Text + "';";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                int i = commandDatabase.ExecuteNonQuery();

                if (i != 0)
                {
                    MessageBox.Show("Usunięto rekord!");
                }
                else
                {
                    MessageBox.Show("Wpisz poprawne ID!");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
