namespace SistemaInformes.Configuraciones
{
    partial class FrmConfigDocs
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
            this.BtnExaminarNominas = new DevExpress.XtraEditors.SimpleButton();
            this.BtnExaminarReportes = new DevExpress.XtraEditors.SimpleButton();
            this.TxtPathInformes = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.BtnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.TxtPathReportes = new DevExpress.XtraEditors.TextEdit();
            this.TxtPathNominas = new DevExpress.XtraEditors.TextEdit();
            this.BtnExaminarInformes = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.FdInformes = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            this.FdReportes = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            this.FdNominas = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPathInformes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPathReportes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPathNominas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.BtnExaminarNominas);
            this.layoutControl1.Controls.Add(this.BtnExaminarReportes);
            this.layoutControl1.Controls.Add(this.TxtPathInformes);
            this.layoutControl1.Controls.Add(this.TxtPathReportes);
            this.layoutControl1.Controls.Add(this.TxtPathNominas);
            this.layoutControl1.Controls.Add(this.BtnExaminarInformes);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(296, 282, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(600, 193);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // BtnExaminarNominas
            // 
            this.BtnExaminarNominas.Location = new System.Drawing.Point(484, 145);
            this.BtnExaminarNominas.Name = "BtnExaminarNominas";
            this.BtnExaminarNominas.Size = new System.Drawing.Size(101, 22);
            this.BtnExaminarNominas.StyleController = this.layoutControl1;
            this.BtnExaminarNominas.TabIndex = 9;
            this.BtnExaminarNominas.Text = "Examinar";
            this.BtnExaminarNominas.Click += new System.EventHandler(this.BtnExaminarNominas_Click);
            // 
            // BtnExaminarReportes
            // 
            this.BtnExaminarReportes.Location = new System.Drawing.Point(484, 111);
            this.BtnExaminarReportes.Name = "BtnExaminarReportes";
            this.BtnExaminarReportes.Size = new System.Drawing.Size(101, 22);
            this.BtnExaminarReportes.StyleController = this.layoutControl1;
            this.BtnExaminarReportes.TabIndex = 8;
            this.BtnExaminarReportes.Text = "Examinar";
            this.BtnExaminarReportes.Click += new System.EventHandler(this.BtnExaminarReportes_Click);
            // 
            // TxtPathInformes
            // 
            this.TxtPathInformes.Location = new System.Drawing.Point(72, 79);
            this.TxtPathInformes.MenuManager = this.barManager1;
            this.TxtPathInformes.Name = "TxtPathInformes";
            this.TxtPathInformes.Size = new System.Drawing.Size(400, 20);
            this.TxtPathInformes.StyleController = this.layoutControl1;
            this.TxtPathInformes.TabIndex = 4;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BtnGuardar,
            this.BtnCancelar});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnGuardar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnCancelar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
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
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(600, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 193);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(600, 32);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 193);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(600, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 193);
            // 
            // TxtPathReportes
            // 
            this.TxtPathReportes.Location = new System.Drawing.Point(72, 113);
            this.TxtPathReportes.MenuManager = this.barManager1;
            this.TxtPathReportes.Name = "TxtPathReportes";
            this.TxtPathReportes.Size = new System.Drawing.Size(400, 20);
            this.TxtPathReportes.StyleController = this.layoutControl1;
            this.TxtPathReportes.TabIndex = 5;
            // 
            // TxtPathNominas
            // 
            this.TxtPathNominas.Location = new System.Drawing.Point(72, 147);
            this.TxtPathNominas.MenuManager = this.barManager1;
            this.TxtPathNominas.Name = "TxtPathNominas";
            this.TxtPathNominas.Size = new System.Drawing.Size(400, 20);
            this.TxtPathNominas.StyleController = this.layoutControl1;
            this.TxtPathNominas.TabIndex = 6;
            // 
            // BtnExaminarInformes
            // 
            this.BtnExaminarInformes.Location = new System.Drawing.Point(484, 77);
            this.BtnExaminarInformes.Name = "BtnExaminarInformes";
            this.BtnExaminarInformes.Size = new System.Drawing.Size(101, 22);
            this.BtnExaminarInformes.StyleController = this.layoutControl1;
            this.BtnExaminarInformes.TabIndex = 7;
            this.BtnExaminarInformes.Text = "Examinar";
            this.BtnExaminarInformes.Click += new System.EventHandler(this.BtnExaminarInformes_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleLabelItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(600, 193);
            this.Root.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.ImageOptions.Image = global::SistemaInformes.Images48px.administrative_tools_48px;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(580, 62);
            this.simpleLabelItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.simpleLabelItem1.Text = "Configuración de directorios";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(282, 48);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TxtPathInformes;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 62);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem1.Size = new System.Drawing.Size(469, 34);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem1.Text = "Informes";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(50, 20);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TxtPathReportes;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem2.Size = new System.Drawing.Size(469, 34);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem2.Text = "Reportes";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(50, 20);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.TxtPathNominas;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 130);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem3.Size = new System.Drawing.Size(469, 43);
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem3.Text = "Nominas";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(50, 20);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.BtnExaminarInformes;
            this.layoutControlItem4.Location = new System.Drawing.Point(469, 62);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem4.Size = new System.Drawing.Size(111, 34);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.BtnExaminarReportes;
            this.layoutControlItem5.Location = new System.Drawing.Point(469, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem5.Size = new System.Drawing.Size(111, 34);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.BtnExaminarNominas;
            this.layoutControlItem6.Location = new System.Drawing.Point(469, 130);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem6.Size = new System.Drawing.Size(111, 43);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // FdInformes
            // 
            this.FdInformes.SelectedPath = "C:\\Users\\wilia\\Documents";
            this.FdInformes.Title = "Direcctorio de Informes";
            // 
            // FdReportes
            // 
            this.FdReportes.SelectedPath = "C:\\Users\\wilia\\Documents";
            // 
            // FdNominas
            // 
            this.FdNominas.SelectedPath = "C:\\Users\\wilia\\Documents";
            // 
            // FrmConfigDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 225);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfigDocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfigDocs";
            this.Load += new System.EventHandler(this.FrmConfigDocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtPathInformes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPathReportes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPathNominas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton BtnExaminarNominas;
        private DevExpress.XtraEditors.SimpleButton BtnExaminarReportes;
        private DevExpress.XtraEditors.TextEdit TxtPathInformes;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem BtnGuardar;
        private DevExpress.XtraBars.BarButtonItem BtnCancelar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.TextEdit TxtPathReportes;
        private DevExpress.XtraEditors.TextEdit TxtPathNominas;
        private DevExpress.XtraEditors.SimpleButton BtnExaminarInformes;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.XtraFolderBrowserDialog FdReportes;
        private DevExpress.XtraEditors.XtraFolderBrowserDialog FdNominas;
        public DevExpress.XtraEditors.XtraFolderBrowserDialog FdInformes;
    }
}