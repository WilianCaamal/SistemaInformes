using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CapaNegocios;
using Entidades;
using System.Data.SqlClient;

namespace SistemaInformes.Catalogos
{
    public partial class FrmBeneficiarios : DevExpress.XtraEditors.XtraForm
    {
        BulBeneficiarios bulBeneficiarios = new BulBeneficiarios();
        Beneficiarios objBeneficiario;
        public FrmBeneficiarios()
        {
            InitializeComponent();
            BtnGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Enter);
            BtnCancelar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Escape);
        }

        #region Botones

        private void BtnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (bulBeneficiarios.Agregar(GetBeneficiario()))
                {
                    XtraMessageBox.Show("Registro guardado exitosamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(SqlException ex)
            {
                XtraMessageBox.Show(ex.Message, "Error Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void BtnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //Code
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message, "Error Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //Code
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message, "Error Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        #endregion

        private Beneficiarios GetBeneficiario()
        {
            return new Beneficiarios()
            {
                Nombre = TxtNombre.Text,
                ApellidoPaterno = TxtApellidoP.Text,
                ApellidoMaterno = TxtApellidoM.Text,
                Direccion = TxtDireccion.Text,
                Estatus = true,
                FechaRegistro = DateTime.Now,
                IdPredio = 1,//int.Parse(CboPredio.EditValue.ToString()),
                IdPuesto = 1,//int.Parse(CboPuesto.EditValue.ToString()),
            };
        }

        private void LimpiarCampos()
        {
            TxtNombre.Text = String.Empty;
            TxtApellidoP.Text = String.Empty;
            TxtApellidoM.Text = String.Empty;
            TxtDireccion.Text = String.Empty;
            TxtTelefono.Text = String.Empty;
            CboPuesto.EditValue = 0;
            CboPredio.EditValue = 0;
        }

        private void CargarBeneficiario(int Id)
        {
            try
            {
                //objBeneficiario = new BulBeneficiarios().GetBeneficiario(id);
                TxtNombre.Text = objBeneficiario.Nombre;
                TxtApellidoP.Text = objBeneficiario.ApellidoPaterno;
                TxtApellidoM.Text = objBeneficiario.ApellidoMaterno;
                TxtDireccion.Text = objBeneficiario.Direccion;
                //TxtTelefono.Text = objBeneficiario.Telefono;
                CboPuesto.EditValue = objBeneficiario.IdPuesto;
                CboPredio.EditValue = objBeneficiario.IdPredio;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error Cargar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}