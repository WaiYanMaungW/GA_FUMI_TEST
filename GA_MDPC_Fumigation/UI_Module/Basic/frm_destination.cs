﻿using GA_MDPC_Fumigation.LINQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_MDPC_Fumigation.UI_Module.Basic
{
    public partial class frm_destination : Form
    {
        public frm_destination()
        {
            InitializeComponent();
        }
        public string record_id = "";
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_destination_Load(object sender, EventArgs e)
        {

            if (record_id == "")
                do_new();
            else
                do_load();
            load_list();
        }
        bool do_save_record_verify()
        {
            lbl_message.Text = "";
            bool is_error = false;
            if (tb_destination.Text.Trim() == "")
            {
                is_error = true;
                tb_destination.Focus();
                lbl_message.Text = "Need to type Destination";
            }

            return is_error;
        }
        public bool AutoCloseAfterSave = false;
        string do_save_record()
        {

            btn_delete.Enabled = true;
            Linq_FumigationDataContext dc = new Linq_FumigationDataContext(Program.get_main_connection());
            Mst_Destination the_record = new Mst_Destination();

            try
            {
                if (do_save_record_verify()) return "";

                if (record_id != "")
                {
                    the_record = (from c in dc.Mst_Destinations where record_id == c.DestinationID select c).FirstOrDefault();

                }
                else
                {
                    the_record = new Mst_Destination()
                    {

                        CreatedBy = Program.get_current_user_id(),
                        CreatedOn = DateTime.Now,
                        Active = true,
                        LastAction = Guid.NewGuid().ToString(),
                        DestinationID = Guid.NewGuid().ToString(),
                        ModifiedOn = DateTime.Now,
                        ModifiedBy = Program.get_current_user_id()

                    };
                    dc.Mst_Destinations.InsertOnSubmit(the_record);
                }

                //#region updatelog
                //HR_Staff log_obj = dc.GetChangeSet().Updates.OfType<HR_Staff>().FirstOrDefault();
                //if (log_obj != null)
                //{
                //    if (Controller.Controller_SystemLog.WirteUpdateLog(dc.HR_Staffs.GetModifiedMembers(log_obj).ToList(), record_id, Program.get_current_user_name()) == false)
                //        MessageBox.Show("Warning: System cannot write log file");
                //}
                //#endregion


                the_record.DestinationName = tb_destination.Text;

                the_record.Remark = tb_remark.Text;
                dc.SubmitChanges();

                if (AutoCloseAfterSave) this.DialogResult = DialogResult.Yes;
                MessageBox.Show("Record has been saved.", "Save Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (record_id == "new" || record_id == "")
                {
                    record_id = the_record.DestinationID;

                }
                do_load();
                load_list();
                return "success";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Action failed. " + ex.Message, "SORRY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return ex.Message;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            do_save_record();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            do_new();
        }
        void do_new()
        {
            record_id = "";

            tb_destination.Text = "";

            tb_remark.Text = "";
            tb_created_on.Text = "";
            tb_modified_on.Text = "";
            lbl_message.Text = "";




            btn_delete.Enabled = false;
            tb_destination.Focus();
            load_list();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            do_delete();
        }
        void do_delete()
        { // user access;
            if (MessageBox.Show("Are you sure you want to delete this record?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                      DialogResult.Yes)
            {
                Linq_FumigationDataContext dc = new Linq_FumigationDataContext(Program.get_main_connection());
                Mst_Destination the_record = new Mst_Destination();
                the_record = (from c in dc.Mst_Destinations where c.Active == true && c.DestinationID == record_id select c).FirstOrDefault();
                if (the_record == null) throw new Exception("System cannot find the record.");
                the_record.Active = false;
                the_record.ModifiedBy = Program.get_current_user_code();
                the_record.ModifiedOn = DateTime.Now;
                the_record.LastAction = Guid.NewGuid().ToString();
                dc.SubmitChanges();
                do_new();
            }
        }
        void do_load()
        {
            //if (theAccess.AllowSelect == false)
            //{
            //    MessageBox.Show("You don't have permission to view this record.", "Security Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            btn_delete.Enabled = true;
            lbl_message.Text = "";

            Linq_FumigationDataContext dc = new Linq_FumigationDataContext(Program.get_main_connection());
            Mst_DestinationView the_result = (from c in dc.Mst_DestinationViews where c.Active == true && c.DestinationID == record_id select c).FirstOrDefault();
            if (record_id != null || record_id == "")
            {
                tb_destination.Text = the_result.DestinationName;

                tb_remark.Text = the_result.Remark;
                tb_created_on.Text = string.Format("{1} on {0}", the_result.CreatedOn.ToString("dd/MM/yyyy hh:mm tt"), the_result.CreatedByCode);
                tb_modified_on.Text = string.Format("{1} on {0}", the_result.ModifiedOn.ToString("dd/MM/yyyy hh:mm tt"), the_result.ModifiedByCode);



            }
            else { do_new(); }
        }
        void load_list()
        {
            Linq_FumigationDataContext dc = new Linq_FumigationDataContext();
            List<Mst_DestinationView> records = (from c in dc.Mst_DestinationViews
                                                 where c.Active == true
                                                 && ((tb_search.Text == "") || (tb_search.Text != "" &&
                                                 (c.DestinationName.Contains(tb_search.Text) ||

                                                 c.Remark.Contains(tb_search.Text))))
                                                 &&
                                                 ((dtp_from.Checked && dtp_to.Checked && c.CreatedOn.Date >= dtp_from.Value && c.CreatedOn.Date <= dtp_to.Value)
                                                 || (dtp_from.Checked && dtp_to.Checked == false && c.CreatedOn.Date == dtp_from.Value.Date)
                                                 || (dtp_from.Checked == false && dtp_to.Checked == false))
                                          orderby c.DestinationName
                                          select c).ToList();

            gv_list.DataSource = records;
            gv_list.Refresh();
        }

        private void gv_list_DoubleClick(object sender, EventArgs e)
        {
            Mst_DestinationView the_result = (Mst_DestinationView)gc_list.GetRow(gc_list.GetSelectedRows().FirstOrDefault());
            record_id = the_result.DestinationID;

            do_load();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            load_list();
        }
        private void period_changed(object sender, EventArgs e)
        {
            load_list();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            bool baseResult = base.ProcessCmdKey(ref msg, keyData);

            if (keyData == (Keys.Control | Keys.S))// Save
            {
                do_save_record();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.N)) //New
            {
                do_new();
                return true;
            }
            else if ((keyData == Keys.Escape))//Close
            {
                this.Close();
                return true;
            }
            else if ((keyData == Keys.Delete))
            {
                do_delete();
                return true;
            }
            return baseResult;


        }
    }
}
