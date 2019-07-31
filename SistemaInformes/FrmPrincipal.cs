﻿using System;
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
            
            Thread.Sleep(2000);
            this.WindowState = FormWindowState.Maximized;
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            frmLogin.Focus();
        }

        private void BtnApoyos_Click(object sender, EventArgs e)
        {
            FrmApoyos frmApoyos = new FrmApoyos();
            HelperWindows.OpenForm(frmApoyos,HelperWindows.ModeOpen.Normal);
        }

        private void BtnPredios_Click(object sender, EventArgs e)
        {
            FrmPredios frmPredios = new FrmPredios();
            HelperWindows.OpenForm(frmPredios, HelperWindows.ModeOpen.Normal);
        }

        private void BtnServidor_Click(object sender, EventArgs e)
        {
            FrmConfigDB frmConfigDB = new FrmConfigDB();
            HelperWindows.OpenForm(frmConfigDB, HelperWindows.ModeOpen.Dialog);
        }

        private void BtnBeneficiarios_Click(object sender, EventArgs e)
        {
            FrmBeneficiarios frmBeneficiarios = new FrmBeneficiarios();
            HelperWindows.OpenForm(frmBeneficiarios, HelperWindows.ModeOpen.Normal);
        }

        private void BtnDocumentos_Click(object sender, EventArgs e)
        {
            FrmConfigDocs frmConfigDocs = new FrmConfigDocs();
            HelperWindows.OpenForm(frmConfigDocs, HelperWindows.ModeOpen.Normal);
        }
    }
}