namespace SistemaInformes.Catalogos
{
    partial class FrmListaBeneficiarios
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridBeneficiarios = new DevExpress.XtraGrid.GridControl();
            this.gridDatos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnBuscar = new DevExpress.XtraEditors.ButtonEdit();
            this.BmAcciones = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BtnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBeneficiarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BmAcciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridBeneficiarios);
            this.layoutControl1.Controls.Add(this.BtnBuscar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(683, 56, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(635, 272);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridBeneficiarios
            // 
            this.gridBeneficiarios.Location = new System.Drawing.Point(12, 52);
            this.gridBeneficiarios.MainView = this.gridDatos;
            this.gridBeneficiarios.Name = "gridBeneficiarios";
            this.gridBeneficiarios.Size = new System.Drawing.Size(611, 208);
            this.gridBeneficiarios.TabIndex = 4;
            this.gridBeneficiarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDatos});
            // 
            // gridDatos
            // 
            this.gridDatos.GridControl = this.gridBeneficiarios;
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.OptionsBehavior.Editable = false;
            this.gridDatos.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gridDatos.OptionsFind.AlwaysVisible = true;
            this.gridDatos.OptionsView.ShowGroupPanel = false;
            this.gridDatos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridDatos_RowClick);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(62, 64);
            this.BtnBuscar.MenuManager = this.BmAcciones;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "Buscar", -1, true, true, true, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.BtnBuscar.Size = new System.Drawing.Size(205, 20);
            this.BtnBuscar.StyleController = this.layoutControl1;
            this.BtnBuscar.TabIndex = 5;
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
            this.BtnNuevo,
            this.BtnEditar,
            this.BtnEliminar,
            this.BtnCerrar});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnEditar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnEliminar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.BtnCerrar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Barra de estado";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.BtnNuevo.Caption = "Nuevo";
            this.BtnNuevo.Id = 0;
            this.BtnNuevo.ImageOptions.Image = global::SistemaInformes.Images24px.add_24px;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnNuevo_ItemClick);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.BtnEditar.Caption = "Editar";
            this.BtnEditar.Id = 1;
            this.BtnEditar.ImageOptions.Image = global::SistemaInformes.Images24px.edit_property_24px;
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEditar_ItemClick);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.BtnEliminar.Caption = "Eliminar";
            this.BtnEliminar.Id = 2;
            this.BtnEliminar.ImageOptions.Image = global::SistemaInformes.Images24px.delete_24px;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEliminar_ItemClick);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.BtnCerrar.Caption = "Cerrar";
            this.BtnCerrar.Id = 3;
            this.BtnCerrar.ImageOptions.Image = global::SistemaInformes.Images24px.cancel_24px;
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCerrar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BmAcciones;
            this.barDockControlTop.Size = new System.Drawing.Size(635, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 272);
            this.barDockControlBottom.Manager = this.BmAcciones;
            this.barDockControlBottom.Size = new System.Drawing.Size(635, 32);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BmAcciones;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 272);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(635, 0);
            this.barDockControlRight.Manager = this.BmAcciones;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 272);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleLabelItem1,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 0, 10);
            this.Root.Size = new System.Drawing.Size(635, 272);
            this.Root.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.ImageOptions.Image = global::SistemaInformes.Images48px.groups_48px;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 2);
            this.simpleLabelItem1.Size = new System.Drawing.Size(615, 50);
            this.simpleLabelItem1.Text = "Lista de Beneficiarios";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(227, 48);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridBeneficiarios;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(615, 212);
            this.layoutControlItem1.Text = "GridBeneficiarios";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FrmListaBeneficiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 304);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaBeneficiarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListaBeneficiarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBeneficiarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BmAcciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridBeneficiarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDatos;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ButtonEdit BtnBuscar;
        private DevExpress.XtraBars.BarManager BmAcciones;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem BtnNuevo;
        private DevExpress.XtraBars.BarButtonItem BtnEditar;
        private DevExpress.XtraBars.BarButtonItem BtnEliminar;
        private DevExpress.XtraBars.BarButtonItem BtnCerrar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}