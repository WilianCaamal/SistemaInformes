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
    public partial class FrmListaPredios : DevExpress.XtraEditors.XtraForm
    {
        BllPredios bulPredios = new BllPredios();
        public FrmListaPredios()
        {
            InitializeComponent();
        }

        private void FrmListaPredios_Load(object sender, EventArgs e)
        {
            CargarPredios();
        }

        private void CargarPredios()
        {
            try
            {
                gridPredios.DataSource = bulPredios.ListarTodos();
                ConfigGrid();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Error Cargar Predios",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ConfigGrid()
        {
            gridDatos.Columns["IdPredio"].Visible = false;
            gridDatos.Columns["FechaEdicion"].Visible = false;
            gridDatos.Columns["FechaEliminado"].Visible = false;
            gridDatos.Columns["Estatus"].Visible = false;
            gridDatos.Columns["Superficie"].Caption = "Superficie [Ha]";
        }

        private void BtnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPredios frm = new FrmPredios();
            frm.ShowDialog();
        }
    }
}