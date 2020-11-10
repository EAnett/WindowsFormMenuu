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
    public partial class TagModositas : Form
    {
        public TagModositas()
        {
            InitializeComponent();
        }

        private void TagModositas_Load(object sender, EventArgs e)
        {
        }

        private void TagModositas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }

        private void button_Vissza_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.nyito.Show();
        }

        private void button_Modositas_Click(object sender, EventArgs e)
        {
            int azonn = Convert.ToInt32(textBox_Azonodito);
            if (String.IsNullOrWhiteSpace(textBox_Azonodito.Text.Trim()))
            {
                MessageBox.Show("Adja meg az azonosítót!!", "Kitöltési Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string nevv = textBox_Nev.Text.Trim();
            if (String.IsNullOrWhiteSpace(nevv))
            {
                MessageBox.Show("Adja meg a nevet!", "Kitöltési Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            int szulevv = Convert.ToInt32(textBox_Szulev.Text);
            if (String.IsNullOrWhiteSpace(textBox_Szulev.Text.Trim()))
            {
                MessageBox.Show("Adja meg a születlsi évet!", "Kitöltési Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int irszamm = Convert.ToInt32(textBox_Irszam.Text);
            if (String.IsNullOrWhiteSpace(textBox_Irszam.Text.Trim()))
            {
                MessageBox.Show("Adja meg az irányítószámot!", "Kitöltési Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string orszz = comboBox_Orszag.Text.Trim();
            if (String.IsNullOrEmpty(orszz))
            {
                MessageBox.Show("Kérem addjon országot", "Kitöltési Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Program.sql.CommandText = "UPDATE `ugyfel` SET `azon`='" + azonn + "',`nev`='" + nevv + "',`szulev`='" + szulevv + "',`irszam`='" + irszamm + "',`orsz`='" + orszz + "' WHERE 1";
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
        }
    }
}
