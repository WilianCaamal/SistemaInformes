using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class BulPredios
    {
        DalPredios dal = new DalPredios();
        public List<Predios> ListarTodos()
        {
            return dal.ListarTodos();
        }
    }
}
