using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInformes.Util
{
    public static class HelperWindows
    {
        public static void OpenForm(XtraForm xtraForm,ModeOpen modo)
        {
            if (Application.OpenForms[xtraForm.Name] != null)
            {
                Application.OpenForms[xtraForm.Name].Activate();
            }
            else
            {
                switch (modo)
                {
                    case ModeOpen.Normal:
                        xtraForm.Show();
                        break;
                    case ModeOpen.Dialog:
                        xtraForm.ShowDialog();
                        break;
                    default:
                        
                        break;
                }
            }
        }
        public enum ModeOpen{
            Normal,Dialog
        }

        public static void IsEmptyComponent(LayoutControl layout)
        {
            int controlCount=0;
            Control control;
            while (controlCount < layout.Controls.Count)
            {
                control = layout.Controls[controlCount];
                XtraMessageBox.Show(control.ToString());
                if (control.Text == String.Empty)
                {

                }
                switch (control)
                {
                    //case :
                    //    break;
                    default:
                        break;
                }
                controlCount++;
            }
        }
    }
}
