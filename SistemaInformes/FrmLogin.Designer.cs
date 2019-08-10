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
            this.components = new System.ComponentModel.Container();
            this.BarAcciones = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.BtnAcceder = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.TxtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtContrasena = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ChkRecordar = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.BarAcciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtContrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkRecordar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // BarAcciones
            // 
            this.BarAcciones.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.BarAcciones.DockControls.Add(this.barDockControlTop);
            this.BarAcciones.DockControls.Add(this.barDockControlBottom);
            this.BarAcciones.DockControls.Add(this.barDockControlLeft);
            this.BarAcciones.DockControls.Add(this.barDockControlRight);
            this.BarAcciones.Form = this;
            this.BarAcciones.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BtnAcceder,
            this.BtnCancelar});
            this.BarAcciones.MaxItemId = 2;
            this.BarAcciones.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnAcceder, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnCancelar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // BtnAcceder
            // 
            this.BtnAcceder.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.BtnAcceder.Caption = "Acceder";
            this.BtnAcceder.Id = 0;
            this.BtnAcceder.ImageOptions.Image = global::SistemaInformes.Images24px.ok_24px;
            this.BtnAcceder.Name = "BtnAcceder";
            this.BtnAcceder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAcceder_ItemClick);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.BtnCancelar.Caption = "Cancelar";
            this.BtnCancelar.Id = 1;
            this.BtnCancelar.ImageOptions.Image = global::SistemaInformes.Images24px.cancel_24px;
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCancelar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarAcciones;
            this.barDockControlTop.Size = new System.Drawing.Size(218, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 203);
            this.barDockControlBottom.Manager = this.BarAcciones;
            this.barDockControlBottom.Size = new System.Drawing.Size(218, 32);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarAcciones;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 203);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(218, 0);
            this.barDockControlRight.Manager = this.BarAcciones;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 203);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TxtUsuario);
            this.layoutControl1.Controls.Add(this.TxtContrasena);
            this.layoutControl1.Controls.Add(this.ChkRecordar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(322, 209, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(218, 203);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleLabelItem1,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(218, 203);
            this.Root.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.simpleLabelItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.simpleLabelItem1.Size = new System.Drawing.Size(198, 43);
            this.simpleLabelItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.simpleLabelItem1.Text = "Inicio de sesión";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(151, 23);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(32, 76);
            this.TxtUsuario.MenuManager = this.BarAcciones;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(154, 20);
            this.TxtUsuario.StyleController = this.layoutControl1;
            this.TxtUsuario.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TxtUsuario;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 43);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(198, 50);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 20, 5, 5);
            this.layoutControlItem1.Text = "Usuario";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(151, 13);
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(32, 126);
            this.TxtContrasena.MenuManager = this.BarAcciones;
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(154, 20);
            this.TxtContrasena.StyleController = this.layoutControl1;
            this.TxtContrasena.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TxtContrasena;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 93);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(198, 50);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 20, 5, 5);
            this.layoutControlItem2.Text = "Contraseña";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(151, 13);
            // 
            // ChkRecordar
            // 
            this.ChkRecordar.Location = new System.Drawing.Point(32, 160);
            this.ChkRecordar.MenuManager = this.BarAcciones;
            this.ChkRecordar.Name = "ChkRecordar";
            this.ChkRecordar.Properties.Caption = "Recordar usuario";
            this.ChkRecordar.Size = new System.Drawing.Size(164, 19);
            this.ChkRecordar.StyleController = this.layoutControl1;
            this.ChkRecordar.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ChkRecordar;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 143);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(198, 40);
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 10, 5, 5);
            this.layoutControlItem3.Text = "Recordar";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 235);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarAcciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtContrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkRecordar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager BarAcciones;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem BtnAcceder;
        private DevExpress.XtraBars.BarButtonItem BtnCancelar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit TxtUsuario;
        private DevExpress.XtraEditors.TextEdit TxtContrasena;
        private DevExpress.XtraEditors.CheckEdit ChkRecordar;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}