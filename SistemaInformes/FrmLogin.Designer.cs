namespace SistemaInformes
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnAcceder = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.TxtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.TxtContrasenia = new DevExpress.XtraEditors.TextEdit();
            this.ChkRecordar = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtContrasenia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkRecordar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(58, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Inicio de Sesión";
            // 
            // BtnAcceder
            // 
            this.BtnAcceder.Location = new System.Drawing.Point(36, 174);
            this.BtnAcceder.Name = "BtnAcceder";
            this.BtnAcceder.Size = new System.Drawing.Size(75, 30);
            this.BtnAcceder.TabIndex = 1;
            this.BtnAcceder.Text = "Acceder";
            // 
            // BtnSalir
            // 
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir.Location = new System.Drawing.Point(117, 174);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 30);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(36, 61);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(150, 20);
            this.TxtUsuario.TabIndex = 3;
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Location = new System.Drawing.Point(36, 106);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.Size = new System.Drawing.Size(150, 20);
            this.TxtContrasenia.TabIndex = 4;
            // 
            // ChkRecordar
            // 
            this.ChkRecordar.Location = new System.Drawing.Point(36, 141);
            this.ChkRecordar.Name = "ChkRecordar";
            this.ChkRecordar.Properties.Caption = "Recordar usuario.";
            this.ChkRecordar.Size = new System.Drawing.Size(115, 19);
            this.ChkRecordar.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Usuario";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Contraseña";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.BtnAcceder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnSalir;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ChkRecordar);
            this.Controls.Add(this.TxtContrasenia);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAcceder);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtContrasenia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkRecordar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnAcceder;
        private DevExpress.XtraEditors.SimpleButton BtnSalir;
        private DevExpress.XtraEditors.TextEdit TxtUsuario;
        private DevExpress.XtraEditors.TextEdit TxtContrasenia;
        private DevExpress.XtraEditors.CheckEdit ChkRecordar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}