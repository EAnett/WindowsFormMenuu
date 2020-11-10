using MySqlX.XDevAPI;
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

namespace WindowsFormMenuu
{
    public partial class TagUj : Form
    {
        public TagUj()
        {
            InitializeComponent();
        }

        private void TagUj_FromClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }

        private void textBox_Irszam_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_Vissza_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.nyito.Show();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            int azon = Convert.ToInt32(textBox_Azonosito);
            if (String.IsNullOrWhiteSpace(textBox_Azonosito.Text.Trim()))
            {
                MessageBox.Show("Adja meg az azonosítót!", "Kitöltési Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Azonosito.Focus();
                return;
            }
            string nev = textBox_Nev.Text.Trim();
            if (String.IsNullOrWhiteSpace(nev))
            {
                MessageBox.Show("A név megadása kötelező!", "Kitöltési Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Nev.Focus();
                return;
            }
            int szulev = Convert.ToInt32(textBox_Szulev);
            if (String.IsNullOrWhiteSpace(textBox_Szulev.Text.Trim()))
            {
                MessageBox.Show("A születési év mező kitöltése kötelező!", "Kitöltési hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Szulev.Focus();
                return;
            }
            int irszam = Convert.ToInt32(textBox_Irszam.Text);
            if (String.IsNullOrWhiteSpace(textBox_Irszam.Text.Trim()))
            {
                MessageBox.Show("Adja meg az irányítószámot!", "Kitöltési hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Irszam.Focus();
                return;
            }
            if (comboBox_Orszag.SelectedIndex < 0)
            {
                MessageBox.Show("Válassza ki az országot!", "Kitöltési hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_Orszag.Focus();
                return;
            }
            string orsz = (string)comboBox_Orszag.SelectedItem;
            Program.sql.CommandText= "INSERT INTO `ugyfel`(`azon`, `nev`, `szulev`, `irszam`, `orsz`) VALUES ('" + azon + "','" + nev + "','" + szulev + "','" + irszam + "','" + orsz + "')";
            try
            {
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                Environment.Exit(0);
                return;
            }
            textBox_Azonosito.Text = "";
            textBox_Nev.Text = "";
            textBox_Szulev.Text = "";
            textBox_Irszam.Text = "";
            comboBox_Orszag.SelectedIndex = -1;
        }
    }
}
