using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DalMunicipios
    {
        public List<Municipios> ListarTodos()
        {
            return Db.GetContext().Municipios.ToList();
        }

        public List<Municipios> GetByIdEstado(int IdEstado)
        {
            return Db.GetContext().Municipios.Where(m => m.IdEstado == IdEstado).ToList();
        }
    }
}
