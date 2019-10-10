using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DalLocalidades
    {
        public List<Localidades> ListarTodas()
        {
            return Db.GetContext().Localidades.ToList();
        }

        public List<Localidades> GetByMunicipio(int IdMunicipio)
        {
            return Db.GetContext().Localidades.Where(l => l.IdMunicipio.Equals(IdMunicipio)).ToList();
        }
    }
}
