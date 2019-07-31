namespace SistemaInformes
{
    partial class FrmPrincipal
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
            DevExpress.XtraSplashScreen.SplashScreenManager SplashManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SistemaInformes.SplashBienvenida), true, false);
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnApoyos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnPredios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnBeneficiarios = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement10 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement11 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.BtnServidor = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement13 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bsUsuario = new DevExpress.XtraBars.BarStaticItem();
            this.bsImpresora = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.accordionControlElement11});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(205, 333);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.Text = "accordionControl1";
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.BtnApoyos,
            this.BtnPredios,
            this.BtnBeneficiarios});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.Image = global::SistemaInformes.ResourcesImages24px.dossier_folder_24px;
            this.accordionControlElement1.Name = "accordionControlElement1";
            toolTipTitleItem1.Text = "Catalogos";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.accordionControlElement1.SuperTip = superToolTip1;
            this.accordionControlElement1.Text = "Catalogos";
            // 
            // BtnApoyos
            // 
            this.BtnApoyos.ImageOptions.Image = global::SistemaInformes.ResourcesImages24px.ledger_24px;
            this.BtnApoyos.Name = "BtnApoyos";
            this.BtnApoyos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnApoyos.Text = "Apoyos";
            this.BtnApoyos.Click += new System.EventHandler(this.BtnApoyos_Click);
            // 
            // BtnPredios
            // 
            this.BtnPredios.ImageOptions.Image = global::SistemaInformes.ResourcesImages24px.map_marker_24px;
            this.BtnPredios.Name = "BtnPredios";
            this.BtnPredios.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnPredios.Text = "Predios";
            this.BtnPredios.Click += new System.EventHandler(this.BtnPredios_Click);
            // 
            // BtnBeneficiarios
            // 
            this.BtnBeneficiarios.ImageOptions.Image = global::SistemaInformes.ResourcesImages24px.groups_24px;
            this.BtnBeneficiarios.Name = "BtnBeneficiarios";
            this.BtnBeneficiarios.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnBeneficiarios.Text = "Beneficiarios";
            this.BtnBeneficiarios.Click += new System.EventHandler(this.BtnBeneficiarios_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement7,
            this.accordionControlElement8});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.accordionControlElement2.ImageOptions.Image = global::SistemaInformes.ResourcesImages24px.overview_pages_2_24px;
            this.accordionControlElement2.Name = "accordionControlElement2";
            toolTipTitleItem2.Text = "Informes";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.accordionControlElement2.SuperTip = superToolTip2;
            this.accordionControlElement2.Text = "Informes";
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.ImageOptions.Image = global::SistemaInformes.ResourcesImages24px.view_details_24px;
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement7.Text = "Todos";
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.ImageOptions.Image = global::SistemaInformes.ResourcesImages24px.add_24px;
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement8.Text = "Nuevo";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement9,
            this.accordionControlElement10});
            this.accordionControlElement3.ImageOptions.Image = global::SistemaInformes.ResourcesImages24px.estimate_24px;
            this.accordionControlElement3.Name = "accordionControlElement3";
            toolTipTitleItem3.Text = "Nominas";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.accordionControlElement3.SuperTip = superToolTip3;
            this.accordionControlElement3.Text = "Nominas";
            // 
            // accordionControlElement9
            // 
            this.accordionControlElement9.ImageOptions.Image = global::SistemaInformes.ResourcesImages24px.view_details_24px;
            this.accordionControlElement9.Name = "accordionControlElement9";
            this.accordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement9.Text = "Todas";
            // 
            // accordionControlElement10
            // 
            this.accordionControlElement10.ImageOptions.Image = global::SistemaInformes.ResourcesImages24px.add_24px;
            this.accordionControlElement10.Name = "accordionControlElement10";
            this.accordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement10.Text = "Nuevo";
            // 
            // accordionControlElement11
            // 
            this.accordionControlElement11.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.BtnServidor,
            this.accordionControlElement13});
            this.accordionControlElement11.Expanded = true;
            this.accordionControlElement11.ImageOptions.Image = global::SistemaInformes.ResourcesImages24px.maintenance_24px;
            this.accordionControlElement11.Name = "accordionControlElement11";
            toolTipTitleItem4.Text = "Configuración";
            superToolTip4.Items.Add(toolTipTitleItem4);
            this.accordionControlElement11.SuperTip = superToolTip4;
            this.accordionControlElement11.Text = "Configuración";
            // 
            // BtnServidor
            // 
            this.BtnServidor.ImageOptions.Image = global::SistemaInformes.ResourcesImages24px.server_24px;
            this.BtnServidor.Name = "BtnServidor";
            this.BtnServidor.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.BtnServidor.Text = "Servidor";
            this.BtnServidor.Click += new System.EventHandler(this.BtnServidor_Click);
            // 
            // accordionControlElement13
            // 
            this.accordionControlElement13.ImageOptions.Image = global::SistemaInformes.ResourcesImages24px.print_24px;
            this.accordionControlElement13.Name = "accordionControlElement13";
            this.accordionControlElement13.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement13.Text = "Impresora";
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
            this.bsUsuario,
            this.bsImpresora});
            this.barManager1.MaxItemId = 3;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bsUsuario),
            new DevExpress.XtraBars.LinkPersistInfo(this.bsImpresora)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // bsUsuario
            // 
            this.bsUsuario.Caption = "Usuario:";
            this.bsUsuario.Id = 0;
            this.bsUsuario.Name = "bsUsuario";
            // 
            // bsImpresora
            // 
            this.bsImpresora.Caption = "Impresora:";
            this.bsImpresora.Id = 1;
            this.bsImpresora.Name = "bsImpresora";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(699, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 333);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(699, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 333);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(699, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 333);
            // 
            // bar1
            // 
            this.bar1.BarName = "Personalizada 3";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Personalizada 3";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 358);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.MdiChildCaptionFormatString = "{0} - {0}";
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Informes";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnApoyos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnPredios;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnBeneficiarios;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement10;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement11;
        private DevExpress.XtraBars.Navigation.AccordionControlElement BtnServidor;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement13;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem bsUsuario;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem bsImpresora;
        private DevExpress.XtraBars.Bar bar1;
    }
}