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
using SistemaInformes.Util;
using Entidades;
using CapaNegocios;
using System.Data.SqlClient;

namespace SistemaInformes.Catalogos
{
    public partial class FrmPredios : DevExpress.XtraEditors.XtraForm
    {
        BllPredios bllPredios = new BllPredios();
        BllEstados bllEstados = new BllEstados();
        BllMunicipios bllMunicipios = new BllMunicipios();
        BllLocalidades bllLocalidades = new BllLocalidades();
        public int Id { get; set; }
        public FrmPredios()
        {
            InitializeComponent();
            BtnGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Enter);
            BtnCancelar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Escape);
        }

        #region Botones

        private void BtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void BtnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Eliminara un registro \n ¿Desea continuar?","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Id == 0)
                {
                    if (bllPredios.Agregar(GetPredio()))
                    {
                        XtraMessageBox.Show("Registro guardado exitosamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    //if (bllBeneficiarios.Editar(GetBeneficiario()))
                    //{
                    //    XtraMessageBox.Show("Registro editado exitosamente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
                DialogResult = DialogResult.Yes;
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message, "Error Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        #endregion

        #region Metodos
        private Predios GetPredio()
        {
            return new Predios() {
                Nombre = TxtNombrePredio.Text,
                Superficie = Convert.ToDouble(TxtSuperficie.Text),
                
            };
        }

        #endregion

        private void FrmPredios_Load(object sender, EventArgs e)
        {
            CargarEstados();
        }

        private void CargarEstados()
        {
            try
            {
                CboEstado.Properties.DataSource = bllEstados.ListarTodos();
                CboEstado.Properties.DisplayMember = "Nombre";
                CboEstado.Properties.ValueMember = "IdEstado";
                CboEstado.Properties.PopulateColumns();
                CboEstado.Properties.Columns["IdEstado"].Visible = false;
                CboEstado.EditValue = 0;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        
        public void CargarMunicipios()
        {
            try
            {
                CboMunicipio.Properties.DataSource = bllMunicipios.ListarTodos();
                CboMunicipio.Properties.DisplayMember = "Nombre";
                CboMunicipio.Properties.ValueMember = "IdMunicipio";
                CboMunicipio.Properties.PopulateColumns();
                CboMunicipio.Properties.Columns["IdEstado"].Visible = false;
                CboMunicipio.EditValue = 0;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}