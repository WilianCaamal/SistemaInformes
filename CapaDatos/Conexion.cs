using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos
{
    public static class Db
    {
        private static DataEntitiesDataContext context;
        public static DataEntitiesDataContext GetContext()
        {
            if (context != null)
            {
                return context;
            }
            else
            {
                return new DataEntitiesDataContext(Properties.Settings.Default.StringConnection);
            }
        }
    }
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
