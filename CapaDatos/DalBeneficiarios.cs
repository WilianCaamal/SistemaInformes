using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos
{
    public class DalBeneficiarios
    {
        
        public bool Agregar(Beneficiarios beneficiario)
        {
            DataEntitiesDataContext context = new DataEntitiesDataContext("Data Source=.;Initial Catalog=SistemaInformes;Integrated Security=True");
            context.Beneficiarios.InsertOnSubmit(beneficiario);
            context.SubmitChanges();
            return true;
        }
    }
}
