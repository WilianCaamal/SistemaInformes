using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace CapaNegocios
{
    public class BllApoyos
    {
        DalApoyos dal = new DalApoyos();

        public List<Apoyos> ListarTodos()
        {
            return dal.ListarTodos();
        }
    }
}
