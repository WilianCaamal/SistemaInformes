using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DalApoyos
    {
        public List<Apoyos> ListarTodos()
        {
            return Db.GetContext().Apoyos.Where(a => a.Estatus == true).ToList();
        }
    }
}
