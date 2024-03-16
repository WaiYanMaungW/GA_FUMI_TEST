namespace GA_MDPC_Fumigation.UI_Module.Main
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_exporter = new DevExpress.XtraBars.BarButtonItem();
            this.btn_consignee = new DevExpress.XtraBars.BarButtonItem();
            this.btn_units = new DevExpress.XtraBars.BarButtonItem();
            this.btn_place_of_loading = new DevExpress.XtraBars.BarButtonItem();
            this.btn_conveyance = new DevExpress.XtraBars.BarButtonItem();
            this.btn_destination = new DevExpress.XtraBars.BarButtonItem();
            this.btn_chemical = new DevExpress.XtraBars.BarButtonItem();
            this.btn_exposure_period = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_temperature = new DevExpress.XtraBars.BarButtonItem();
            this.btn_password_change = new DevExpress.XtraBars.BarButtonItem();
            this.btn_fumigation_certificate = new DevExpress.XtraBars.BarButtonItem();
            this.btn_authorized_signature = new DevExpress.XtraBars.BarButtonItem();
            this.btn_fumigation_2 = new DevExpress.XtraBars.BarButtonItem();
            this.rib_basic = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grp_exporter = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grp_consignee = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rib_main = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mdiMgr = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.dlf = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_running_no = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiMgr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_exporter,
            this.btn_consignee,
            this.btn_units,
            this.btn_place_of_loading,
            this.btn_conveyance,
            this.btn_destination,
            this.btn_chemical,
            this.btn_exposure_period,
            this.barButtonItem1,
            this.btn_temperature,
            this.btn_password_change,
            this.btn_fumigation_certificate,
            this.btn_authorized_signature,
            this.btn_fumigation_2,
            this.btn_running_no});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(8);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rib_basic,
            this.rib_main,
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbon.Size = new System.Drawing.Size(980, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_exporter
            // 
            this.btn_exporter.Caption = "Exporter";
            this.btn_exporter.Id = 1;
            this.btn_exporter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_exporter.ImageOptions.Image")));
            this.btn_exporter.Name = "btn_exporter";
            this.btn_exporter.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_exporter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_exporter_ItemClick);
            // 
            // btn_consignee
            // 
            this.btn_consignee.Caption = "Consignee";
            this.btn_consignee.Id = 3;
            this.btn_consignee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_consignee.ImageOptions.Image")));
            this.btn_consignee.Name = "btn_consignee";
            this.btn_consignee.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_consignee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_consignee_ItemClick);
            // 
            // btn_units
            // 
            this.btn_units.Caption = "Units";
            this.btn_units.Id = 5;
            this.btn_units.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_units.ImageOptions.Image")));
            this.btn_units.Name = "btn_units";
            this.btn_units.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_units.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_units_ItemClick);
            // 
            // btn_place_of_loading
            // 
            this.btn_place_of_loading.Caption = "Place of loading";
            this.btn_place_of_loading.Id = 6;
            this.btn_place_of_loading.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_place_of_loading.ImageOptions.Image")));
            this.btn_place_of_loading.Name = "btn_place_of_loading";
            this.btn_place_of_loading.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_place_of_loading.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_place_of_loading_ItemClick);
            // 
            // btn_conveyance
            // 
            this.btn_conveyance.Caption = "Means of conveyance";
            this.btn_conveyance.Id = 7;
            this.btn_conveyance.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_conveyance.ImageOptions.Image")));
            this.btn_conveyance.Name = "btn_conveyance";
            this.btn_conveyance.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_conveyance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_conveyance_ItemClick);
            // 
            // btn_destination
            // 
            this.btn_destination.Caption = "Destination";
            this.btn_destination.Id = 8;
            this.btn_destination.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_destination.ImageOptions.Image")));
            this.btn_destination.Name = "btn_destination";
            this.btn_destination.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_destination.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_destination_ItemClick);
            // 
            // btn_chemical
            // 
            this.btn_chemical.Caption = "Chemicals";
            this.btn_chemical.Id = 9;
            this.btn_chemical.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_chemical.ImageOptions.Image")));
            this.btn_chemical.Name = "btn_chemical";
            this.btn_chemical.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_chemical.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_chemical_ItemClick);
            // 
            // btn_exposure_period
            // 
            this.btn_exposure_period.Caption = "Exposure Period";
            this.btn_exposure_period.Id = 10;
            this.btn_exposure_period.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_exposure_period.ImageOptions.Image")));
            this.btn_exposure_period.Name = "btn_exposure_period";
            this.btn_exposure_period.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_exposure_period.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_exposure_period_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Concentration\r\n";
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btn_temperature
            // 
            this.btn_temperature.Caption = "Temperature";
            this.btn_temperature.Id = 12;
            this.btn_temperature.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_temperature.ImageOptions.Image")));
            this.btn_temperature.Name = "btn_temperature";
            this.btn_temperature.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_temperature.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_temperature_ItemClick);
            // 
            // btn_password_change
            // 
            this.btn_password_change.Caption = "Change Password ";
            this.btn_password_change.Id = 13;
            this.btn_password_change.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_password_change.ImageOptions.Image")));
            this.btn_password_change.Name = "btn_password_change";
            this.btn_password_change.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_password_change.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_password_change_ItemClick);
            // 
            // btn_fumigation_certificate
            // 
            this.btn_fumigation_certificate.Caption = "Fumigation Certificate";
            this.btn_fumigation_certificate.Id = 14;
            this.btn_fumigation_certificate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_fumigation_certificate.ImageOptions.Image")));
            this.btn_fumigation_certificate.Name = "btn_fumigation_certificate";
            this.btn_fumigation_certificate.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_fumigation_certificate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_fumigation_certificate_ItemClick);
            // 
            // btn_authorized_signature
            // 
            this.btn_authorized_signature.Caption = "Authorized Signature";
            this.btn_authorized_signature.Id = 15;
            this.btn_authorized_signature.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_authorized_signature.ImageOptions.Image")));
            this.btn_authorized_signature.Name = "btn_authorized_signature";
            this.btn_authorized_signature.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_authorized_signature.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_authorized_signature_ItemClick);
            // 
            // btn_fumigation_2
            // 
            this.btn_fumigation_2.Caption = "Fumigation Data List";
            this.btn_fumigation_2.Id = 16;
            this.btn_fumigation_2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_fumigation_2.ImageOptions.Image")));
            this.btn_fumigation_2.Name = "btn_fumigation_2";
            this.btn_fumigation_2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_fumigation_2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_fumigation_2_ItemClick);
            // 
            // rib_basic
            // 
            this.rib_basic.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.grp_exporter,
            this.grp_consignee,
            this.ribbonPageGroup4});
            this.rib_basic.Name = "rib_basic";
            this.rib_basic.Text = "Basic";
            // 
            // grp_exporter
            // 
            this.grp_exporter.ItemLinks.Add(this.btn_exporter);
            this.grp_exporter.Name = "grp_exporter";
            this.grp_exporter.Text = "Exporter";
            // 
            // grp_consignee
            // 
            this.grp_consignee.ItemLinks.Add(this.btn_consignee);
            this.grp_consignee.Name = "grp_consignee";
            this.grp_consignee.Text = "Consignee";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_units);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_place_of_loading);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_conveyance);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_destination);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_chemical);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_exposure_period);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_temperature);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_authorized_signature);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "---";
            // 
            // rib_main
            // 
            this.rib_main.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rib_main.Name = "rib_main";
            this.rib_main.Text = "Main";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_fumigation_certificate);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_fumigation_2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Fumigation";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Setting";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_password_change);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Account";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 575);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(8);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(980, 28);
            // 
            // mdiMgr
            // 
            this.mdiMgr.AppearancePage.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdiMgr.AppearancePage.Header.Options.UseFont = true;
            this.mdiMgr.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.mdiMgr.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdiMgr.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.mdiMgr.AppearancePage.HeaderActive.Options.UseFont = true;
            this.mdiMgr.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader;
            this.mdiMgr.MdiParent = this;
            // 
            // dlf
            // 
            this.dlf.LookAndFeel.SkinName = "Office 2019 Colorful";
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_running_no);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "System";
            // 
            // btn_running_no
            // 
            this.btn_running_no.Caption = "Running Fc No";
            this.btn_running_no.Id = 17;
            this.btn_running_no.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_running_no.ImageOptions.Image")));
            this.btn_running_no.Name = "btn_running_no";
            this.btn_running_no.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_running_no.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_running_no_ItemClick);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 603);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_main.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Name = "frm_main";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MPDC Fumigation Certificate";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiMgr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_main;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_basic;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grp_exporter;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager mdiMgr;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraBars.BarButtonItem btn_exporter;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grp_consignee;
        public DevExpress.LookAndFeel.DefaultLookAndFeel dlf;
        private DevExpress.XtraBars.BarButtonItem btn_consignee;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btn_units;
        private DevExpress.XtraBars.BarButtonItem btn_place_of_loading;
        private DevExpress.XtraBars.BarButtonItem btn_conveyance;
        private DevExpress.XtraBars.BarButtonItem btn_destination;
        private DevExpress.XtraBars.BarButtonItem btn_chemical;
        private DevExpress.XtraBars.BarButtonItem btn_exposure_period;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_temperature;
        private DevExpress.XtraBars.BarButtonItem btn_password_change;
        private DevExpress.XtraBars.BarButtonItem btn_fumigation_certificate;
        private DevExpress.XtraBars.BarButtonItem btn_authorized_signature;
        private DevExpress.XtraBars.BarButtonItem btn_fumigation_2;
        private DevExpress.XtraBars.BarButtonItem btn_running_no;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}