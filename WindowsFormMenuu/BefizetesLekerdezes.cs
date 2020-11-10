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
    public partial class BefizetesLekerdezes : Form
    {
        public BefizetesLekerdezes()
        {
            InitializeComponent();
        }

        private void BefizetesLekerdezes_Load(object sender, EventArgs e)
        {
            dataGridView_Lekerdez.ColumnCount = 3;
            dataGridView_Lekerdez.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Lekerdez.Columns[0].Name = "azon";
            dataGridView_Lekerdez.Columns[0].HeaderText = "Azonosító";
            dataGridView_Lekerdez.Columns[1].Name = "datum";
            dataGridView_Lekerdez.Columns[1].HeaderText = "Dátum";
            dataGridView_Lekerdez.Columns[2].Name = "osszeg";
            dataGridView_Lekerdez.Columns[2].HeaderText = "Összeg";
            try
            {
                Program.sql.CommandText = "SELECT `azon`,`datum`,`osszeg` FROM `befiz` WHERE 1";
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int ujIndex = dataGridView_Lekerdez.Rows.Add();
                        dataGridView_Lekerdez.Rows[ujIndex].Cells[0].Value = dr.GetInt32("azon");
                        dataGridView_Lekerdez.Rows[ujIndex].Cells[1].Value = dr.GetString("osszeg");
                        dataGridView_Lekerdez.Rows[ujIndex].Cells[2].Value = dr.GetDateTime("datum").ToString("yyyy-MM-dd");
                    }
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Adatbázis hiba!");
            }

        }

        private void BefizetesLekerdezes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }
    }
}
