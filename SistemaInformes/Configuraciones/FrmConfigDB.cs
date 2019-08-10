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
    public partial class FrmConfigDB : DevExpress.XtraEditors.XtraForm
    {
        public FrmConfigDB()
        {
            InitializeComponent();
            BtnGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Enter);
            BtnCancelar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Escape);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConfigDB_Load(object sender, EventArgs e)
        {
            TxtServer.Text = SettingsConnection.Default.Host;
            TxtDataBase.Text = SettingsConnection.Default.DataBase;
            TxtUser.Text = SettingsConnection.Default.User;
            TxtPassword.Text = SettingsConnection.Default.Password;
        }

        private void BtnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SettingsConnection.Default.Host = TxtServer.Text.Trim();
            SettingsConnection.Default.DataBase = TxtDataBase.Text.Trim();
            SettingsConnection.Default.User = TxtUser.Text.Trim();
            SettingsConnection.Default.Password = TxtPassword.Text.Trim();
            SettingsConnection.Default.Save();
            this.Close();
        }

        private void BtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}