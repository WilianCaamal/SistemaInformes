using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace CapaNegocios
{
    public class BllLocalidades
    {
        private DalLocalidades dal = new DalLocalidades();
        public List<Localidades> ListarTodas()
        {
            return dal.ListarTodas();
        }

        public List<Localidades> GetByIdMunicipio(int IdMunicipio)
        {
            return dal.GetByMunicipio(IdMunicipio);
        }
    }
}
