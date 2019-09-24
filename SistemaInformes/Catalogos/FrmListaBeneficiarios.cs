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
using Entidades;
using CapaNegocios;
using SistemaInformes.Util;

namespace SistemaInformes.Catalogos
{
    public partial class FrmListaBeneficiarios : DevExpress.XtraEditors.XtraForm
    {
        BllBeneficiarios bllBeneficiarios = new BllBeneficiarios();
        private int IdBeneficiario { get; set; }
        public FrmListaBeneficiarios()
        {
            InitializeComponent();
        }

        private void FrmListaBeneficiarios_Load(object sender, EventArgs e)
        {
            CargarBeneficiarios();
        }

        private void CargarBeneficiarios()
        {
            try
            {
                gridBeneficiarios.DataSource = bllBeneficiarios.ListarTodos();
                ConfigGrid();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Cargar Beneficiarios",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ConfigGrid()
        {
            gridDatos.Columns["IdBeneficiario"].Visible = false; //IdBeneficiario
            gridDatos.Columns["Direccion"].Visible = false; //Direccion
            gridDatos.Columns["IdPuesto"].Visible = false; //IdPuesto
            gridDatos.Columns["FechaEdicion"].Visible = false; //FechaEdicion
            gridDatos.Columns["FechaEliminado"].Visible = false; //FechaEliminacion
            gridDatos.Columns["Estatus"].Visible = false; //Estatus
            gridDatos.Columns["Telefono"].Visible = false; //Telefono
        }

        #region Botones

        private void BtnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBeneficiarios frmBeneficiarios = new FrmBeneficiarios();
            HelperWindows.OpenForm(frmBeneficiarios, HelperWindows.ModeOpen.Dialog);
            if (frmBeneficiarios.DialogResult == DialogResult.Yes)
            {
                CargarBeneficiarios();
            }
        }

        private void BtnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBeneficiarios frmBeneficiarios = new FrmBeneficiarios();
            frmBeneficiarios.Id = IdBeneficiario;
            if (IdBeneficiario != 0)
            {
                HelperWindows.OpenForm(frmBeneficiarios, HelperWindows.ModeOpen.Dialog);
                if (frmBeneficiarios.DialogResult == DialogResult.Yes)
                {
                    CargarBeneficiarios();
                }
            }
        }

        private void BtnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (IdBeneficiario != 0)
                {
                    if (XtraMessageBox.Show("Eliminar Registro", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (bllBeneficiarios.Eliminar(IdBeneficiario))
                        {
                            XtraMessageBox.Show("Registro eliminado exitosamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarBeneficiarios();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        #endregion

        private void gridDatos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            IdBeneficiario = int.Parse(gridDatos.GetRowCellValue(e.RowHandle, "IdBeneficiario").ToString());
            
        }
    }
}