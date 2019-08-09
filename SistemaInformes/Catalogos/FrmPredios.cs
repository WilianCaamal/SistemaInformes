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

namespace SistemaInformes.Catalogos
{
    public partial class FrmPredios : DevExpress.XtraEditors.XtraForm
    {
        public FrmPredios()
        {
            InitializeComponent();
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
            HelperWindows.IsEmptyComponent(layoutControl2);
        }

        private void BtnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        #endregion

        #region Metodos



        #endregion

        private void FrmPredios_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    BtnCancelar_ItemClick(null, null);
                    break;
                case Keys.Enter:
                    BtnGuardar_ItemClick(null, null);
                    break;
                default:
                    break;
            }
        }
    }
}