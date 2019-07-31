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
using SistemaInformes.Configuraciones;

namespace SistemaInformes.Configuraciones
{
    public partial class FrmConfigDocs : DevExpress.XtraEditors.XtraForm
    {
        public FrmConfigDocs()
        {
            InitializeComponent();
        }

        private void BtnExaminarInformes_Click(object sender, EventArgs e)
        {
            FdInformes.UseParentFormIcon = true;
            FdInformes.ShowDialog();
            TxtPathInformes.Text = FdInformes.SelectedPath + "\\Informes";
        }

        private void BtnExaminarReportes_Click(object sender, EventArgs e)
        {
            FdReportes.ShowDialog();
            TxtPathReportes.Text = FdReportes.SelectedPath + "\\Reportes";
        }

        private void BtnExaminarNominas_Click(object sender, EventArgs e)
        {
            FdNominas.ShowDialog();
            TxtPathNominas.Text = FdNominas.SelectedPath + "\\Nominas";
        }

        private void BtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SettingsDocuments.Default.PathInfornes = TxtPathInformes.Text.Trim();
            SettingsDocuments.Default.PathReportes = TxtPathReportes.Text.Trim();
            SettingsDocuments.Default.PathNominas = TxtPathNominas.Text.Trim();
            SettingsDocuments.Default.Save();

        }

        private void FrmConfigDocs_Load(object sender, EventArgs e)
        {
            TxtPathInformes.Text = SettingsDocuments.Default.PathInfornes + "\\Informes";
            TxtPathReportes.Text = SettingsDocuments.Default.PathReportes + "\\Reportes";
            TxtPathNominas.Text = SettingsDocuments.Default.PathNominas + "\\Nominas";

        }
    }
}