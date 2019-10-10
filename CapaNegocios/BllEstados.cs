using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class BllEstados
    {
        private DalEstados dal = new DalEstados();
        public List<Estados> ListarTodos()
        {
            return dal.ListarTodos();
        }
    }
}
