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
    public partial class BefizetesUj : Form
    {
        public BefizetesUj()
        {
            InitializeComponent();
        }

        private void button_Vissza2_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.nyito.Show();
        }

        private void button_Befizet_Click(object sender, EventArgs e)
        {
            int azon = Convert.ToInt32(textBox_Azonosito2.Text);
            if (String.IsNullOrWhiteSpace(textBox_Azonosito2.Text.Trim()))
            {
                MessageBox.Show("Adja meg az azonosítót!", "Kitöltési hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Azonosito2.Focus();
                return;
            }
            DateTime datum = dateTimePicker_Datum.Value;

            int osszeg = Convert.ToInt32(textBox_Osszeg.Text);
            if (String.IsNullOrWhiteSpace(textBox_Osszeg.Text.Trim()))
            {
                MessageBox.Show("Adja meg az összeget!", "Kitöltési hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Osszeg.Focus();
                return;
            }
            Program.sql.CommandText = "INSERT INTO `befiz`(`azon`, `datum`, `osszeg`) VALUES('" + azon + "','" + datum.ToString("yyyy-MM-dd") + "','" + osszeg + "')";
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
            textBox_Azonosito2.Text = "";
            textBox_Osszeg.Text = "";
        }
    }
}
    

