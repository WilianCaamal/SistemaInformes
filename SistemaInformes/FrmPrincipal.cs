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
using System.Threading;
using SistemaInformes.Catalogos;
using SistemaInformes.Configuraciones;

namespace SistemaInformes
{
    public partial class FrmPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
            Thread.Sleep(2000);
            this.WindowState = FormWindowState.Maximized;
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            frmLogin.Focus();
        }

        private void BtnApoyos_Click(object sender, EventArgs e)
        {
            FrmApoyos frmApoyos = new FrmApoyos();
            frmApoyos.MdiParent = this;
            frmApoyos.Show();
        }

        private void BtnPredios_Click(object sender, EventArgs e)
        {
            FrmPredios frmPredios = new FrmPredios();
            frmPredios.MdiParent = this;
            frmPredios.Show();
        }

        private void BtnServidor_Click(object sender, EventArgs e)
        {
            FrmConfigDB frmConfigDB = new FrmConfigDB();
            frmConfigDB.ShowDialog();
        }

        private void BtnBeneficiarios_Click(object sender, EventArgs e)
        {
            FrmBeneficiarios frmBeneficiarios = new FrmBeneficiarios();
            frmBeneficiarios.Show();
        }
    }
}