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

namespace SistemaInformes
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            BtnAcceder.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Enter);
            BtnCancelar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Escape);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Activate();
            TxtUsuario.Focus();
        }

        private void BtnAcceder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}