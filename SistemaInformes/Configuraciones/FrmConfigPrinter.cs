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

namespace SistemaInformes.Configuraciones
{
    public partial class FrmConfigPrinter : DevExpress.XtraEditors.XtraForm
    {
        public FrmConfigPrinter()
        {
            InitializeComponent();
            BtnGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Enter);
            BtnCancelar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Escape);
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            PdImpresora.ShowDialog();
            TxtNombreImpresora.Text = PdImpresora.PrinterSettings.PrinterName;
        }

        private void BtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SettingsPrinter.Default.NamePrinter = TxtNombreImpresora.Text.Trim();
            SettingsPrinter.Default.Save();
            this.Close();
        }

        private void FrmConfigPrinter_Load(object sender, EventArgs e)
        {
            TxtNombreImpresora.Text = SettingsPrinter.Default.NamePrinter;
        }

        private void FrmConfigPrinter_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    BtnCancelar_ItemClick(null,null);
                    break;
                case Keys.Enter:
                    BtnGuardar_ItemClick(null,null);
                    break;
                default:
                    break;
            }
        }
    }
}