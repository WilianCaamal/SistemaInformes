using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DalPredios
    {
        public List<Predios> ListarTodos()
        {
            return Db.GetContext().Predios.Where(p=>p.Estatus.Equals(true)).ToList();
        }
    }
}
