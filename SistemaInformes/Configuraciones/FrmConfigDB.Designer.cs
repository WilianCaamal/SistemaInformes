namespace SistemaInformes.Configuraciones
{
    partial class FrmConfigDB
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.TxtServer = new DevExpress.XtraEditors.TextEdit();
            this.TxtDataBase = new DevExpress.XtraEditors.TextEdit();
            this.TxtUser = new DevExpress.XtraEditors.TextEdit();
            this.TxtPassword = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.BmAcciones = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BtnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDataBase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BmAcciones)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TxtServer);
            this.layoutControl1.Controls.Add(this.TxtDataBase);
            this.layoutControl1.Controls.Add(this.TxtUser);
            this.layoutControl1.Controls.Add(this.TxtPassword);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(617, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(255, 191);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // TxtServer
            // 
            this.TxtServer.Location = new System.Drawing.Point(88, 57);
            this.TxtServer.Name = "TxtServer";
            this.TxtServer.Size = new System.Drawing.Size(150, 20);
            this.TxtServer.StyleController = this.layoutControl1;
            this.TxtServer.TabIndex = 4;
            // 
            // TxtDataBase
            // 
            this.TxtDataBase.Location = new System.Drawing.Point(88, 89);
            this.TxtDataBase.Name = "TxtDataBase";
            this.TxtDataBase.Size = new System.Drawing.Size(150, 20);
            this.TxtDataBase.StyleController = this.layoutControl1;
            this.TxtDataBase.TabIndex = 5;
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(88, 121);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(150, 20);
            this.TxtUser.StyleController = this.layoutControl1;
            this.TxtUser.TabIndex = 6;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(88, 153);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Properties.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(150, 20);
            this.TxtPassword.StyleController = this.layoutControl1;
            this.TxtPassword.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleLabelItem1,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(255, 191);
            this.Root.Spacing = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.Root.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.simpleLabelItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleLabelItem1.CustomizationFormText = "Configuración de conexion";
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.MaxSize = new System.Drawing.Size(0, 40);
            this.simpleLabelItem1.MinSize = new System.Drawing.Size(70, 40);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.simpleLabelItem1.Size = new System.Drawing.Size(233, 40);
            this.simpleLabelItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.simpleLabelItem1.Text = "Configuración de conexion";
            this.simpleLabelItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(50, 20);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TxtDataBase;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlItem2.Size = new System.Drawing.Size(233, 32);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem2.Text = "Base de datos";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TxtServer;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlItem1.Size = new System.Drawing.Size(233, 32);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem1.Text = "Servidor";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.TxtUser;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlItem3.Size = new System.Drawing.Size(233, 32);
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem3.Text = "Usuario";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.TxtPassword;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 136);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlItem6.Size = new System.Drawing.Size(233, 33);
            this.layoutControlItem6.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem6.Text = "Contraseña";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(68, 13);
            // 
            // BmAcciones
            // 
            this.BmAcciones.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.BmAcciones.DockControls.Add(this.barDockControlTop);
            this.BmAcciones.DockControls.Add(this.barDockControlBottom);
            this.BmAcciones.DockControls.Add(this.barDockControlLeft);
            this.BmAcciones.DockControls.Add(this.barDockControlRight);
            this.BmAcciones.Form = this;
            this.BmAcciones.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BtnGuardar,
            this.BtnCancelar});
            this.BmAcciones.MaxItemId = 4;
            this.BmAcciones.StatusBar = this.bar2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Barra de estado";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnGuardar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnCancelar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Barra de estado";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.BtnGuardar.Caption = "Guardar";
            this.BtnGuardar.Id = 0;
            this.BtnGuardar.ImageOptions.Image = global::SistemaInformes.Images24px.save_24px;
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGuardar_ItemClick);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.BtnCancelar.Caption = "Cancelar";
            this.BtnCancelar.Id = 3;
            this.BtnCancelar.ImageOptions.Image = global::SistemaInformes.Images24px.cancel_24px;
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCancelar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BmAcciones;
            this.barDockControlTop.Size = new System.Drawing.Size(255, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 191);
            this.barDockControlBottom.Manager = this.BmAcciones;
            this.barDockControlBottom.Size = new System.Drawing.Size(255, 32);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BmAcciones;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 191);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(255, 0);
            this.barDockControlRight.Manager = this.BmAcciones;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 191);
            // 
            // FrmConfigDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 223);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfigDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.FrmConfigDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDataBase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BmAcciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit TxtServer;
        private DevExpress.XtraEditors.TextEdit TxtDataBase;
        private DevExpress.XtraEditors.TextEdit TxtUser;
        private DevExpress.XtraEditors.TextEdit TxtPassword;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraBars.BarManager BmAcciones;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem BtnGuardar;
        private DevExpress.XtraBars.BarButtonItem BtnCancelar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}