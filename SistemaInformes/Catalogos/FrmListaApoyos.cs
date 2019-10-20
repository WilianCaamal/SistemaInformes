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

namespace SistemaInformes.Catalogos
{
    public partial class FrmListaApoyos : DevExpress.XtraEditors.XtraForm
    {
        BllApoyos bllApoyos = new BllApoyos();
        public FrmListaApoyos()
        {
            InitializeComponent();
        }
        #region Botones
        private void BtnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BtnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BtnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BtnCerrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        #endregion

        #region Metodos
        private void FrmListaApoyos_Load(object sender, EventArgs e)
        {
            ListarApoyos();
        }

        private void ListarApoyos()
        {
            try
            {
                gridApoyos.DataSource = bllApoyos.ListarTodos();
                ConfigGrid();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Error Cargar Apoyos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ConfigGrid()
        {
            gridDatos.Columns["IdApoyo"].Visible = false;
            gridDatos.Columns["FechaRegistro"].Visible = false;
            gridDatos.Columns["FechaEdicion"].Visible = false;
            gridDatos.Columns["FechaEliminado"].Visible = false;
            gridDatos.Columns["Estatus"].Visible = false;
        }
        #endregion
    }
}