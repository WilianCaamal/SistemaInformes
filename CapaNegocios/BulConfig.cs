using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class BulConfig
    {
        private Conexion conexion = new Conexion();
        public void LoadConfig()
        {
            conexion.LoadConfig();
        }

        public bool SaveConfig(string host, string database, string user, string password)
        {
            return conexion.SaveConfig(host, database, user, password);
        }
    }
}
