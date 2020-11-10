using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormMenuu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.tagUj.Show();
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.tagModositas.Show();
        }

        private void újToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.befizetesUj.Show();
        }

        private void lekérdezésekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.befizetesLekerdezes.Show();
        }
    }
}
