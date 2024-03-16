namespace GA_MDPC_Fumigation.UI_Module.System_Main
{
    partial class frm_system_log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_system_log));
            this.gc_logdetail = new DevExpress.XtraGrid.GridControl();
            this.gv_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_log = new DevExpress.XtraGrid.GridControl();
            this.gc_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.tb_record_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gc_logdetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_list)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_logdetail
            // 
            this.gc_logdetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gc_logdetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gc_logdetail.Location = new System.Drawing.Point(605, 57);
            this.gc_logdetail.MainView = this.gv_list;
            this.gc_logdetail.Margin = new System.Windows.Forms.Padding(4);
            this.gc_logdetail.Name = "gc_logdetail";
            this.gc_logdetail.Size = new System.Drawing.Size(976, 568);
            this.gc_logdetail.TabIndex = 172;
            this.gc_logdetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_list});
            // 
            // gv_list
            // 
            this.gv_list.ColumnPanelRowHeight = 44;
            this.gv_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn5});
            this.gv_list.DetailHeight = 437;
            this.gv_list.GridControl = this.gc_logdetail;
            this.gv_list.Name = "gv_list";
            this.gv_list.OptionsBehavior.Editable = false;
            this.gv_list.OptionsView.ShowFooter = true;
            this.gv_list.RowHeight = 37;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Field Name";
            this.gridColumn2.FieldName = "FieldName";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FieldName", "Total  {0}  records")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 274;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Old Value";
            this.gridColumn4.FieldName = "OldValue";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 381;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.Caption = "New Value";
            this.gridColumn5.FieldName = "NewValue";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 350;
            // 
            // gc_log
            // 
            this.gc_log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gc_log.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.gc_log.Location = new System.Drawing.Point(5, 57);
            this.gc_log.MainView = this.gc_list;
            this.gc_log.Margin = new System.Windows.Forms.Padding(4);
            this.gc_log.Name = "gc_log";
            this.gc_log.Size = new System.Drawing.Size(598, 568);
            this.gc_log.TabIndex = 171;
            this.gc_log.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gc_list});
            // 
            // gc_list
            // 
            this.gc_list.ColumnPanelRowHeight = 44;
            this.gc_list.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.gridColumn1,
            this.gridColumn3});
            this.gc_list.DetailHeight = 437;
            this.gc_list.GridControl = this.gc_log;
            this.gc_list.Name = "gc_list";
            this.gc_list.OptionsBehavior.Editable = false;
            this.gc_list.OptionsView.ShowFooter = true;
            this.gc_list.RowHeight = 37;
            this.gc_list.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gc_list_RowCellClick);
            // 
            // id
            // 
            this.id.Caption = "gridColumn1";
            this.id.FieldName = "SystemLogID";
            this.id.MinWidth = 25;
            this.id.Name = "id";
            this.id.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SystemLogID", "Total {0} records")});
            this.id.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Log By";
            this.gridColumn1.FieldName = "LogBy";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "LogBy", "Total {0} records")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Log Date";
            this.gridColumn3.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
            this.gridColumn3.FieldName = "LogDateTime";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 94;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_close.Location = new System.Drawing.Point(1410, 10);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(171, 40);
            this.btn_close.TabIndex = 173;
            this.btn_close.Text = "Close";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tb_record_id
            // 
            this.tb_record_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_record_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_record_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_record_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_record_id.ForeColor = System.Drawing.Color.Black;
            this.tb_record_id.Location = new System.Drawing.Point(915, 13);
            this.tb_record_id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_record_id.Name = "tb_record_id";
            this.tb_record_id.Size = new System.Drawing.Size(401, 17);
            this.tb_record_id.TabIndex = 170;
            this.tb_record_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_record_id.TextChanged += new System.EventHandler(this.tb_record_id_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(639, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 169;
            this.label1.Text = "Modified Detail";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(30, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 168;
            this.label6.Text = "Modified On";
            // 
            // frm_system_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(1616, 635);
            this.Controls.Add(this.gc_logdetail);
            this.Controls.Add(this.gc_log);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tb_record_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_system_log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sysrtem Log";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_system_log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_logdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_logdetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_list;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.GridControl gc_log;
        private DevExpress.XtraGrid.Views.Grid.GridView gc_list;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private System.Windows.Forms.TextBox tb_record_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}