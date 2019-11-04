using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class BllPredios
    {
        DalPredios dal = new DalPredios();
        public List<Predios> ListarTodos()
        {
            return dal.ListarTodos();
        }


        public bool Guardar(Predios predio)
        {
            if(predio.IdPredio > 0)
            {
                return dal.Agregar(predio);
            }
            else
            {
                //return dal.Editar(predio);
                return true;
            }
        }
    }
}
