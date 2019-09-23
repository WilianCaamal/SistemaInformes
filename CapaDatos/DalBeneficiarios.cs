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
        public List<Beneficiarios> ListarTodos()
        {
            return Db.GetContext().Beneficiarios.ToList();
        }
        public bool Agregar(Beneficiarios beneficiario)
        {
            Db.GetContext().Beneficiarios.InsertOnSubmit(beneficiario);
            Db.GetContext().SubmitChanges();
            return true;
        }

        public Beneficiarios GetById(int Id)
        {
            return Db.GetContext().Beneficiarios.FirstOrDefault(b => b.IdBeneficiario.Equals(Id));
        }

        public bool Editar(Beneficiarios beneficiario)
        {
            Beneficiarios objBeneficiario = Db.GetContext().Beneficiarios.SingleOrDefault(b => b.IdBeneficiario.Equals(beneficiario.IdBeneficiario));
            objBeneficiario.Nombre = beneficiario.Nombre;
            objBeneficiario.ApellidoMaterno = beneficiario.ApellidoMaterno;
            objBeneficiario.ApellidoPaterno = beneficiario.ApellidoPaterno;
            objBeneficiario.Direccion = beneficiario.Direccion;
            objBeneficiario.FechaEdicion = beneficiario.FechaEdicion;
            objBeneficiario.IdPredio = beneficiario.IdPredio;
            objBeneficiario.IdPuesto = beneficiario.IdPuesto;
            objBeneficiario.Telefono = beneficiario.Telefono;
            Db.GetContext().SubmitChanges();
            return true;
        }
    }
}
