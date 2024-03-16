namespace GA_MDPC_Fumigation.UI_Module.Fumigation
{
    partial class frm_fumis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_fumis));
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_issued = new System.Windows.Forms.DateTimePicker();
            this.dtp_fumigation = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.gv_list = new DevExpress.XtraGrid.GridControl();
            this.gc_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_new = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(932, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 141;
            this.label5.Text = "Date issued";
            // 
            // dtp_issued
            // 
            this.dtp_issued.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_issued.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_issued.Checked = false;
            this.dtp_issued.CustomFormat = "MM/dd/yyyy";
            this.dtp_issued.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_issued.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_issued.Location = new System.Drawing.Point(935, 299);
            this.dtp_issued.Name = "dtp_issued";
            this.dtp_issued.ShowCheckBox = true;
            this.dtp_issued.Size = new System.Drawing.Size(199, 24);
            this.dtp_issued.TabIndex = 140;
            this.dtp_issued.ValueChanged += new System.EventHandler(this.period_change);
            // 
            // dtp_fumigation
            // 
            this.dtp_fumigation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fumigation.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fumigation.Checked = false;
            this.dtp_fumigation.CustomFormat = "MM/dd/yyyy";
            this.dtp_fumigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fumigation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fumigation.Location = new System.Drawing.Point(932, 251);
            this.dtp_fumigation.Name = "dtp_fumigation";
            this.dtp_fumigation.ShowCheckBox = true;
            this.dtp_fumigation.Size = new System.Drawing.Size(199, 24);
            this.dtp_fumigation.TabIndex = 139;
            this.dtp_fumigation.ValueChanged += new System.EventHandler(this.period_change);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(932, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 142;
            this.label4.Text = "Date of Fumigation";
            // 
            // gv_list
            // 
            this.gv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_list.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gv_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_list.Location = new System.Drawing.Point(12, 12);
            this.gv_list.MainView = this.gc_list;
            this.gv_list.Name = "gv_list";
            this.gv_list.Size = new System.Drawing.Size(822, 651);
            this.gv_list.TabIndex = 128;
            this.gv_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gc_list,
            this.gridView1});
            this.gv_list.DoubleClick += new System.EventHandler(this.gv_list_DoubleClick);
            // 
            // gc_list
            // 
            this.gc_list.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_list.Appearance.HeaderPanel.Options.UseFont = true;
            this.gc_list.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_list.Appearance.Row.Options.UseFont = true;
            this.gc_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn8,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn2,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn9});
            this.gc_list.GridControl = this.gv_list;
            this.gc_list.Name = "gc_list";
            this.gc_list.OptionsBehavior.AutoExpandAllGroups = true;
            this.gc_list.OptionsBehavior.Editable = false;
            this.gc_list.OptionsView.RowAutoHeight = true;
            this.gc_list.OptionsView.ShowFooter = true;
            this.gc_list.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn8, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.Caption = "id";
            this.gridColumn1.FieldName = "FumigationID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn8.AppearanceCell.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.Caption = "FC NO";
            this.gridColumn8.FieldName = "FCNO";
            this.gridColumn8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn8.ImageOptions.Image")));
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FCNO", "Total {0} Records")});
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Exporter ";
            this.gridColumn3.FieldName = "ExporterName";
            this.gridColumn3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn3.ImageOptions.Image")));
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 77;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Commodity";
            this.gridColumn4.FieldName = "Commodity";
            this.gridColumn4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn4.ImageOptions.Image")));
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 109;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Chemical";
            this.gridColumn2.FieldName = "ChemicalName";
            this.gridColumn2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn2.ImageOptions.Image")));
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.Caption = "Expouser Period";
            this.gridColumn5.FieldName = "ExpouserPeriod";
            this.gridColumn5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn5.ImageOptions.Image")));
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 109;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.Caption = "Fumigation Date";
            this.gridColumn6.FieldName = "DateOfFumigation";
            this.gridColumn6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn6.ImageOptions.Image")));
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            this.gridColumn6.Width = 114;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn7.AppearanceCell.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.Caption = "Date Issued";
            this.gridColumn7.FieldName = "DateIssued";
            this.gridColumn7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn7.ImageOptions.Image")));
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 91;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Date";
            this.gridColumn9.FieldName = "CreatedOn";
            this.gridColumn9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn9.ImageOptions.Image")));
            this.gridColumn9.MinWidth = 25;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            this.gridColumn9.Width = 68;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gv_list;
            this.gridView1.Name = "gridView1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(897, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 137;
            this.label1.Text = "To";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(871, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 135;
            this.label8.Text = "Search";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label16.Location = new System.Drawing.Point(879, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(236, 29);
            this.label16.TabIndex = 133;
            this.label16.Text = "Fumigation Data lists";
            // 
            // dtp_to
            // 
            this.dtp_to.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_to.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_to.Checked = false;
            this.dtp_to.CustomFormat = "MM/dd/yyyy";
            this.dtp_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_to.Location = new System.Drawing.Point(932, 173);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.ShowCheckBox = true;
            this.dtp_to.Size = new System.Drawing.Size(199, 24);
            this.dtp_to.TabIndex = 132;
            this.dtp_to.ValueChanged += new System.EventHandler(this.period_change);
            // 
            // dtp_from
            // 
            this.dtp_from.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_from.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_from.Checked = false;
            this.dtp_from.CustomFormat = "MM/dd/yyyy";
            this.dtp_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_from.Location = new System.Drawing.Point(932, 143);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.ShowCheckBox = true;
            this.dtp_from.Size = new System.Drawing.Size(199, 24);
            this.dtp_from.TabIndex = 131;
            this.dtp_from.ValueChanged += new System.EventHandler(this.period_change);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(929, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 130;
            this.label3.Text = "...";
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(933, 203);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(199, 24);
            this.tb_search.TabIndex = 129;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_close.Location = new System.Drawing.Point(855, 398);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(279, 50);
            this.btn_close.TabIndex = 136;
            this.btn_close.Text = "Close";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_new
            // 
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.ImageOptions.Image")));
            this.btn_new.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_new.Location = new System.Drawing.Point(855, 342);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(279, 50);
            this.btn_new.TabIndex = 134;
            this.btn_new.Text = "New";
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(881, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 138;
            this.label2.Text = "From";
            // 
            // frm_fumis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1147, 675);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_issued);
            this.Controls.Add(this.dtp_fumigation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gv_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.dtp_from);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_fumis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fumigation Data lists";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_fumis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_issued;
        private System.Windows.Forms.DateTimePicker dtp_fumigation;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.GridControl gv_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gc_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_search;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraEditors.SimpleButton btn_new;
        private System.Windows.Forms.Label label2;
    }
}