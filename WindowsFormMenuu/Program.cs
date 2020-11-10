using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace WindowsFormMenuu
{
    static class Program
    {
        public static TagModositas tagModositas = null;
        public static TagUj tagUj = null;
        public static Form1 nyito = null;
        public static BefizetesUj befizetesUj = null;
        public static BefizetesLekerdezes befizetesLekerdezes = null;
        public static MySqlConnection conn = null;
        public static MySqlCommand sql= null;
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tagdij";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            tagModositas = new TagModositas();
            tagUj = new TagUj();
            nyito = new Form1();
            befizetesUj = new BefizetesUj();
            befizetesLekerdezes = new BefizetesLekerdezes();
            Application.Run(nyito);
        }
    }
}
