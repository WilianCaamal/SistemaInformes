﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace CapaNegocios
{
    public class BllBeneficiarios
    {
        DalBeneficiarios dal = new DalBeneficiarios();
        private readonly String textError = "Los siguientes campos no pueden estar vacios:";
        StringBuilder bodyError = new StringBuilder();

        private void BeneficiarioValido(Beneficiarios beneficiario)
        {
            bodyError.Clear();
            if (beneficiario.Nombre == String.Empty)
                bodyError.Append(" \n * Nombres");
            if (beneficiario.ApellidoPaterno == String.Empty)
                bodyError.Append(" \n * Apellido Paterno");
            if (beneficiario.ApellidoMaterno == String.Empty)
                bodyError.Append(" \n * Apellido Materno");
            if (bodyError.Length > 0)
            {
                throw new Exception(textError + bodyError.ToString());
            }
        }

        public bool Guardar(Beneficiarios beneficiario)
        {
            BeneficiarioValido(beneficiario);
            if (beneficiario.IdBeneficiario > 0)
            {
                return dal.Agregar(beneficiario);
            }
            else
            {
                beneficiario.FechaEdicion = DateTime.Today;
                return dal.Editar(beneficiario);
            }
        }

        public List<Beneficiarios> ListarTodos()
        {
            return dal.ListarTodos();
        }

        public Beneficiarios GetById(int Id)
        {
            return dal.GetById(Id);
        }



        public bool Eliminar(int Id)
        {
            return dal.Eliminar(Id);
        }
    }
}
