using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DalEstados
    {
        public List<Estados> ListarTodos()
        {
            return Db.GetContext().Estados.ToList();
        }
    }
}
