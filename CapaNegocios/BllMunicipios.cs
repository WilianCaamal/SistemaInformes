using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace CapaNegocios
{
    public class BllMunicipios
    {
        private DalMunicipios dal = new DalMunicipios();
        public List<Municipios> ListarTodos()
        {
            return dal.ListarTodos();
        }

        public List<Municipios> GetByIdEstado(int IdEstado)
        {
            return dal.GetByIdEstado(IdEstado);
        }
    }
}
