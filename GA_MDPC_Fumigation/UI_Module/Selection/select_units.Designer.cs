namespace GA_MDPC_Fumigation.UI_Module.Selection
{
    partial class select_units
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(select_units));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_record_count = new System.Windows.Forms.Label();
            this.btn_new = new DevExpress.XtraEditors.SimpleButton();
            this.btn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.gv_list = new DevExpress.XtraGrid.GridControl();
            this.gc_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbl_record_count);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.gv_list);
            this.panel1.Location = new System.Drawing.Point(14, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 457);
            this.panel1.TabIndex = 138;
            // 
            // lbl_record_count
            // 
            this.lbl_record_count.AutoSize = true;
            this.lbl_record_count.BackColor = System.Drawing.Color.Transparent;
            this.lbl_record_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_record_count.ForeColor = System.Drawing.Color.Black;
            this.lbl_record_count.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_record_count.Location = new System.Drawing.Point(4, 372);
            this.lbl_record_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_record_count.Name = "lbl_record_count";
            this.lbl_record_count.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_record_count.Size = new System.Drawing.Size(20, 18);
            this.lbl_record_count.TabIndex = 136;
            this.lbl_record_count.Text = "...";
            // 
            // btn_new
            // 
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.ImageOptions.Image")));
            this.btn_new.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_new.Location = new System.Drawing.Point(191, 372);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(100, 60);
            this.btn_new.TabIndex = 3;
            this.btn_new.Text = "New";
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.ImageOptions.Image")));
            this.btn_clear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_clear.Location = new System.Drawing.Point(83, 372);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 60);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.AppearanceHovered.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_close.AppearanceHovered.Options.UseBackColor = true;
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_close.Location = new System.Drawing.Point(299, 373);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(100, 60);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // gv_list
            // 
            this.gv_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_list.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gv_list.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(38);
            this.gv_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_list.Location = new System.Drawing.Point(0, 0);
            this.gv_list.MainView = this.gc_list;
            this.gv_list.Margin = new System.Windows.Forms.Padding(38);
            this.gv_list.Name = "gv_list";
            this.gv_list.Size = new System.Drawing.Size(399, 363);
            this.gv_list.TabIndex = 5;
            this.gv_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gc_list});
            this.gv_list.DoubleClick += new System.EventHandler(this.gv_list_DoubleClick);
            this.gv_list.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gv_list_KeyDown);
            // 
            // gc_list
            // 
            this.gc_list.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_list.Appearance.HeaderPanel.Options.UseFont = true;
            this.gc_list.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_list.Appearance.Row.Options.UseFont = true;
            this.gc_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.Title});
            this.gc_list.DetailHeight = 4062;
            this.gc_list.GridControl = this.gv_list;
            this.gc_list.Name = "gc_list";
            this.gc_list.OptionsBehavior.Editable = false;
            this.gc_list.OptionsView.RowAutoHeight = true;
            this.gc_list.OptionsView.ShowFooter = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.Caption = "id";
            this.gridColumn1.FieldName = "UnitID";
            this.gridColumn1.MinWidth = 232;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 867;
            // 
            // Title
            // 
            this.Title.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.AppearanceCell.Options.UseFont = true;
            this.Title.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.AppearanceHeader.Options.UseFont = true;
            this.Title.Caption = "Units";
            this.Title.FieldName = "UnitName";
            this.Title.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Title.ImageOptions.Image")));
            this.Title.MinWidth = 232;
            this.Title.Name = "Title";
            this.Title.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Title", "Total {0} Records")});
            this.Title.Visible = true;
            this.Title.VisibleIndex = 0;
            this.Title.Width = 867;
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(14, 51);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(399, 24);
            this.tb_search.TabIndex = 1;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            this.tb_search.DoubleClick += new System.EventHandler(this.gv_list_DoubleClick);
            this.tb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label16.Location = new System.Drawing.Point(13, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 29);
            this.label16.TabIndex = 136;
            this.label16.Text = "Units";
            // 
            // select_units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(432, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.label16);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "select_units";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Units";
            this.Load += new System.EventHandler(this.select_form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.select_form_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbl_record_count;
        private DevExpress.XtraEditors.SimpleButton btn_new;
        private DevExpress.XtraEditors.SimpleButton btn_clear;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraGrid.GridControl gv_list;
        private DevExpress.XtraGrid.Views.Grid.GridView gc_list;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn Title;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label16;
    }
}