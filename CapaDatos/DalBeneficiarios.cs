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
            return Db.GetContext().Beneficiarios.Where(b=>b.Estatus.Equals(true)).ToList();
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

        public bool Editar(Beneficiarios obj)
        {
            Beneficiarios objBeneficiario = Db.GetContext().Beneficiarios.SingleOrDefault(b => b.IdBeneficiario.Equals(obj.IdBeneficiario));
            objBeneficiario.Nombre = obj.Nombre;
            objBeneficiario.ApellidoMaterno = obj.ApellidoMaterno;
            objBeneficiario.ApellidoPaterno = obj.ApellidoPaterno;
            objBeneficiario.Direccion = obj.Direccion;
            objBeneficiario.FechaEdicion = obj.FechaEdicion;
            objBeneficiario.IdPredio = obj.IdPredio;
            objBeneficiario.IdPuesto = obj.IdPuesto;
            objBeneficiario.Telefono = obj.Telefono;
            Db.GetContext().SubmitChanges();
            return true;
        }

        public bool Eliminar(int Id)
        {
            Beneficiarios objBeneficiario = Db.GetContext().Beneficiarios.SingleOrDefault(b => b.IdBeneficiario.Equals(Id));
            objBeneficiario.Estatus = false;
            objBeneficiario.FechaEliminado = DateTime.Today;
            Db.GetContext().SubmitChanges();
            return true;
        }
    }
}
