namespace GA_MDPC_Fumigation.UI_Module.Basic
{
    partial class frm_conveyance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_conveyance));
            this.lbl_message = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_modified_on = new System.Windows.Forms.TextBox();
            this.tb_remark = new System.Windows.Forms.TextBox();
            this.gc_list = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_list = new DevExpress.XtraGrid.GridControl();
            this.tb_created_on = new System.Windows.Forms.TextBox();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_carrier = new System.Windows.Forms.TextBox();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_new = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gc_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_message.Location = new System.Drawing.Point(373, 24);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(23, 17);
            this.lbl_message.TabIndex = 100;
            this.lbl_message.Text = "---";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label16.Location = new System.Drawing.Point(123, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(244, 29);
            this.label16.TabIndex = 99;
            this.label16.Text = "Means of conveyance";
            // 
            // tb_modified_on
            // 
            this.tb_modified_on.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_modified_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_modified_on.Location = new System.Drawing.Point(128, 239);
            this.tb_modified_on.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_modified_on.Name = "tb_modified_on";
            this.tb_modified_on.ReadOnly = true;
            this.tb_modified_on.Size = new System.Drawing.Size(343, 24);
            this.tb_modified_on.TabIndex = 98;
            this.tb_modified_on.TabStop = false;
            // 
            // tb_remark
            // 
            this.tb_remark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_remark.Location = new System.Drawing.Point(128, 103);
            this.tb_remark.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_remark.Multiline = true;
            this.tb_remark.Name = "tb_remark";
            this.tb_remark.Size = new System.Drawing.Size(343, 88);
            this.tb_remark.TabIndex = 3;
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
            this.gridColumn1.FieldName = "CarrierID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // Title
            // 
            this.Title.AppearanceCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.AppearanceCell.Options.UseFont = true;
            this.Title.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.AppearanceHeader.Options.UseFont = true;
            this.Title.Caption = "Means of conveyance";
            this.Title.FieldName = "CarrierName";
            this.Title.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Title.ImageOptions.Image")));
            this.Title.Name = "Title";
            this.Title.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Title", "Total {0} Records")});
            this.Title.Visible = true;
            this.Title.VisibleIndex = 0;
            // 
            // gv_list
            // 
            this.gv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_list.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gv_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_list.Location = new System.Drawing.Point(734, 70);
            this.gv_list.MainView = this.gc_list;
            this.gv_list.Name = "gv_list";
            this.gv_list.Size = new System.Drawing.Size(639, 451);
            this.gv_list.TabIndex = 101;
            this.gv_list.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gc_list});
            this.gv_list.DoubleClick += new System.EventHandler(this.gv_list_DoubleClick);
            // 
            // tb_created_on
            // 
            this.tb_created_on.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_created_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_created_on.Location = new System.Drawing.Point(128, 199);
            this.tb_created_on.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_created_on.Name = "tb_created_on";
            this.tb_created_on.ReadOnly = true;
            this.tb_created_on.Size = new System.Drawing.Size(343, 24);
            this.tb_created_on.TabIndex = 96;
            this.tb_created_on.TabStop = false;
            // 
            // dtp_to
            // 
            this.dtp_to.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_to.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_to.Checked = false;
            this.dtp_to.CustomFormat = "MM/dd/yyyy";
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_to.Location = new System.Drawing.Point(65, 56);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.ShowCheckBox = true;
            this.dtp_to.Size = new System.Drawing.Size(146, 22);
            this.dtp_to.TabIndex = 56;
            this.dtp_to.ValueChanged += new System.EventHandler(this.period_changed);
            // 
            // dtp_from
            // 
            this.dtp_from.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_from.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_from.Checked = false;
            this.dtp_from.CustomFormat = "MM/dd/yyyy";
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_from.Location = new System.Drawing.Point(65, 21);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.ShowCheckBox = true;
            this.dtp_from.Size = new System.Drawing.Size(146, 22);
            this.dtp_from.TabIndex = 55;
            this.dtp_from.ValueChanged += new System.EventHandler(this.period_changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(51, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 119;
            this.label2.Text = "Remark";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(34, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 36);
            this.label6.TabIndex = 116;
            this.label6.Text = "Means of \r\nconveyance";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(13, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "From";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(29, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "To";
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(65, 91);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(146, 24);
            this.tb_search.TabIndex = 52;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(3, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 51;
            this.label8.Text = "Search";
            // 
            // tb_carrier
            // 
            this.tb_carrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_carrier.Location = new System.Drawing.Point(127, 72);
            this.tb_carrier.Name = "tb_carrier";
            this.tb_carrier.Size = new System.Drawing.Size(343, 24);
            this.tb_carrier.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.ImageOptions.Image")));
            this.btn_close.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_close.Location = new System.Drawing.Point(260, 349);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(211, 50);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Close";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_new
            // 
            this.btn_new.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.ImageOptions.Image")));
            this.btn_new.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_new.Location = new System.Drawing.Point(260, 293);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(212, 50);
            this.btn_new.TabIndex = 6;
            this.btn_new.Text = "New";
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_delete.Location = new System.Drawing.Point(31, 349);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(223, 50);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.AppearanceHovered.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_save.AppearanceHovered.Options.UseBackColor = true;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_save.Location = new System.Drawing.Point(31, 293);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(223, 50);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(26, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 121;
            this.label9.Text = "Modified On";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(28, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 120;
            this.label3.Text = "Created On";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.dtp_to);
            this.panel2.Controls.Add(this.dtp_from);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tb_search);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(493, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 146);
            this.panel2.TabIndex = 115;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tb_carrier);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gv_list);
            this.panel1.Controls.Add(this.lbl_message);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.tb_modified_on);
            this.panel1.Controls.Add(this.tb_created_on);
            this.panel1.Controls.Add(this.tb_remark);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 533);
            this.panel1.TabIndex = 95;
            // 
            // frm_conveyance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 557);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_conveyance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Means of conveyance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_conveyance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_list)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_modified_on;
        private System.Windows.Forms.TextBox tb_remark;
        private DevExpress.XtraGrid.Columns.GridColumn Title;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Views.Grid.GridView gc_list;
        private DevExpress.XtraGrid.GridControl gv_list;
        private System.Windows.Forms.TextBox tb_created_on;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_carrier;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraEditors.SimpleButton btn_new;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}