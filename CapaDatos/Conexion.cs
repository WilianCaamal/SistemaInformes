using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        private string ConnectionBase = "Data Source={0};"+
            "Initial Catalog={1};" +
            "User Id={2};"+
            "Password={3}";
        public Conexion()
        {

        }

        public void LoadConfig()
        {
            Console.WriteLine("String -> " + Properties.Settings.Default.StringConnection);
        }

        public bool SaveConfig(string host,string database, string user, string password)
        {
            string con = String.Format(ConnectionBase, host, database, user, password);
            Properties.Settings.Default.StringConnection = con;
            Properties.Settings.Default.Save();
            return true;
        }
    }
}
