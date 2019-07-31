﻿using DevExpress.XtraEditors;
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
                    case ModeOpen.Dialog:
                        xtraForm.ShowDialog();
                        break;
                    default:
                        xtraForm.Show();
                        break;
                }
                xtraForm.Show();
            }
        }
        public enum ModeOpen{
            Normal,Dialog
        }
    }
}
