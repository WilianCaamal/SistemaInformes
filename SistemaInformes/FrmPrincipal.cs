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
using SistemaInformes.Util;

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
            LoadConfiguration();
            Thread.Sleep(2000);
            MenuAccordeon.Enabled = false;
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Focus();
            frmLogin.ShowDialog();

            if (frmLogin.DialogResult == DialogResult.OK)
            {
                MenuAccordeon.Enabled = true;
            }
        }

        #region Botones 

        private void BtnApoyos_Click(object sender, EventArgs e)
        {
            FrmApoyos frmApoyos = new FrmApoyos { MdiParent = this };
            HelperWindows.OpenForm(frmApoyos,HelperWindows.ModeOpen.Normal);
        }

        private void BtnPredios_Click(object sender, EventArgs e)
        {
            FrmPredios frmPredios = new FrmPredios { MdiParent = this };
            HelperWindows.OpenForm(frmPredios, HelperWindows.ModeOpen.Normal);
        }

        private void BtnServidor_Click(object sender, EventArgs e)
        {
            FrmConfigDB frmConfigDB = new FrmConfigDB();
            HelperWindows.OpenForm(frmConfigDB, HelperWindows.ModeOpen.Dialog);
        }

        private void BtnBeneficiarios_Click(object sender, EventArgs e)
        {
            FrmListaBeneficiarios frmBeneficiarios = new FrmListaBeneficiarios{ MdiParent = this,Text = "Lista de Beneficiarios" };
            HelperWindows.OpenForm(frmBeneficiarios, HelperWindows.ModeOpen.Normal);
        }

        private void BtnDocumentos_Click(object sender, EventArgs e)
        {
            FrmConfigDocs frmConfigDocs = new FrmConfigDocs();
            HelperWindows.OpenForm(frmConfigDocs, HelperWindows.ModeOpen.Dialog);
        }

        #endregion

        #region Metodos

        #endregion

        #region Configuracion 

        public void LoadConfiguration()
        {
            BsImpresora.Caption = $"Impresora : {SettingsPrinter.Default.NamePrinter}";
            Timer.Start();
        }

        #endregion

        private void Timer_Tick(object sender, EventArgs e)
        {
            BsHora.Caption = DateTime.Now.ToLongTimeString();
        }

        private void BtnImpresora_Click(object sender, EventArgs e)
        {
            FrmConfigPrinter frmConfigPrinter = new FrmConfigPrinter();
            HelperWindows.OpenForm(frmConfigPrinter,HelperWindows.ModeOpen.Dialog);
        }
    }
}