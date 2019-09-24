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

namespace SistemaInformes.Configuraciones
{
    public partial class FrmConfigDB : DevExpress.XtraEditors.XtraForm
    {
        BulConfig config = new BulConfig();
        public FrmConfigDB()
        {
            InitializeComponent();
            BtnGuardar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Enter);
            BtnCancelar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Escape);
        }

        private void FrmConfigDB_Load(object sender, EventArgs e)
        {
            TxtServer.Text = Connection.Default.Host;
            TxtDataBase.Text = Connection.Default.DataBase;
            TxtUser.Text = Connection.Default.User;
            TxtPassword.Text = Connection.Default.Password;
        }

        private void BtnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveParams();
                bool response = config.SaveConfig(
                    Connection.Default.Host,
                    Connection.Default.DataBase,
                    Connection.Default.User,
                    Connection.Default.Password
                    );

                if (response)
                {
                    XtraMessageBox.Show("Configuración guardada","Configuración",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void SaveParams()
        {
            Connection.Default.Host = TxtServer.Text.Trim();
            Connection.Default.DataBase = TxtDataBase.Text.Trim();
            Connection.Default.User = TxtUser.Text.Trim();
            Connection.Default.Password = TxtPassword.Text.Trim();
            Connection.Default.Save();
        }
    }
}