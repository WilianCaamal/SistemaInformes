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
        DataEntitiesDataContext db = new DataEntitiesDataContext("Data Source=.;Initial Catalog=SistemaInformes;Integrated Security=True");

        public List<Beneficiarios> ListarTodos()
        {
            return db.Beneficiarios.ToList();
        }
        public bool Agregar(Beneficiarios beneficiario)
        {
            DataEntitiesDataContext db = new DataEntitiesDataContext("Data Source=.;Initial Catalog=SistemaInformes;Integrated Security=True");
            db.Beneficiarios.InsertOnSubmit(beneficiario);
            db.SubmitChanges();
            return true;
        }

        public Beneficiarios GetById(int Id)
        {
            return db.Beneficiarios.FirstOrDefault(b => b.IdBeneficiario.Equals(Id));
        }

        public bool Editar(Beneficiarios beneficiario)
        {
            Beneficiarios objBeneficiario = db.Beneficiarios.SingleOrDefault(b => b.IdBeneficiario.Equals(beneficiario.IdBeneficiario));
            objBeneficiario.Nombre = beneficiario.Nombre;
            objBeneficiario.ApellidoMaterno = beneficiario.ApellidoMaterno;
            objBeneficiario.ApellidoPaterno = beneficiario.ApellidoPaterno;
            objBeneficiario.Direccion = beneficiario.Direccion;
            objBeneficiario.FechaEdicion = beneficiario.FechaEdicion;
            objBeneficiario.IdPredio = beneficiario.IdPredio;
            objBeneficiario.IdPuesto = beneficiario.IdPuesto;
            objBeneficiario.Telefono = beneficiario.Telefono;
            db.SubmitChanges();
            return true;
        }
    }
}
