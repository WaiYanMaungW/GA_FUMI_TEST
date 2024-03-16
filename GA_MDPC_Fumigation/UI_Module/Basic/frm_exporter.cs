using GA_MDPC_Fumigation.LINQ;
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
    public partial class frm_exporter : Form
    {
        public frm_exporter()
        {
            InitializeComponent();
        }
        public string record_id = "";
        string picture_id = "";

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_exporter_Load(object sender, EventArgs e)
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
            if (tb_exporter_name.Text.Trim() == "")
            {
                is_error = true;
                tb_exporter_name.Focus();
                lbl_message.Text = "Need to type Exporter Name";
            }

            return is_error;
        }
        public bool AutoCloseAfterSave = false;
        string do_save_record()
        {
          
            btn_delete.Enabled = true;
            Linq_FumigationDataContext dc = new Linq_FumigationDataContext(Program.get_main_connection());
            Mst_Exporter the_record = new Mst_Exporter();

            try
            {
                if (do_save_record_verify()) return "";

                if (record_id != "")
                {
                    the_record = (from c in dc.Mst_Exporters where record_id == c.ExporterID select c).FirstOrDefault();

                }
                else
                {
                    the_record = new Mst_Exporter()
                    {

                        CreatedBy = Program.get_current_user_id(),
                        CreatedOn = DateTime.Now,
                        Active = true,
                        LastAction = Guid.NewGuid().ToString(),
                        ExporterID = Guid.NewGuid().ToString(),
                        ModifiedOn = DateTime.Now,
                        ModifiedBy = Program.get_current_user_id(),
                       
                    };
                    dc.Mst_Exporters.InsertOnSubmit(the_record);
                }

                //#region updatelog
                //HR_Staff log_obj = dc.GetChangeSet().Updates.OfType<HR_Staff>().FirstOrDefault();
                //if (log_obj != null)
                //{
                //    if (Controller.Controller_SystemLog.WirteUpdateLog(dc.HR_Staffs.GetModifiedMembers(log_obj).ToList(), record_id, Program.get_current_user_name()) == false)
                //        MessageBox.Show("Warning: System cannot write log file");
                //}
                //#endregion


                the_record.ExporterName = tb_exporter_name.Text;
                
                dc.SubmitChanges();

                if (AutoCloseAfterSave) this.DialogResult = DialogResult.Yes;
                MessageBox.Show("Record has been saved.", "Save Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (record_id == "new" || record_id == "")
                {
                    record_id = the_record.ExporterID;

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

            tb_exporter_name.Text = "";
           
           // tb_remark.Text = "";
            tb_created_on.Text = "";
            tb_modified_on.Text = "";
            lbl_message.Text = "";

           
            btn_delete.Enabled = false;
            tb_exporter_name.Focus();
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
                Mst_Exporter the_record = new Mst_Exporter();
                the_record = (from c in dc.Mst_Exporters where c.Active == true && c.ExporterID == record_id select c).FirstOrDefault();
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
            Mst_ExporterView the_result = (from c in dc.Mst_ExporterViews where c.Active == true && c.ExporterID == record_id select c).FirstOrDefault();
            if (record_id != null || record_id != "")
            {
                tb_exporter_name.Text = the_result.ExporterName;
              
               // tb_remark.Text = the_result.Remark;
                tb_created_on.Text = string.Format("{1} on {0}", the_result.CreatedOn.ToString("dd/MM/yyyy hh:mm tt"), the_result.CreatedByCode);
                tb_modified_on.Text = string.Format("{1} on {0}", the_result.ModifiedOn.ToString("dd/MM/yyyy hh:mm tt"), the_result.ModifiedByCode);



             
            }
            else { do_new(); }
        }
        void load_list()
        {
            Linq_FumigationDataContext dc = new Linq_FumigationDataContext(Program.get_main_connection());
            List<Mst_ExporterView> records = (from c in dc.Mst_ExporterViews
                                              where c.Active == true
                                                 && ((tb_search.Text == "") || (tb_search.Text != "" &&
                                                 (c.ExporterName.Contains(tb_search.Text) 
                                                 )))
                                                 &&
                                                 ((dtp_from.Checked && dtp_to.Checked && c.CreatedOn.Date >= dtp_from.Value && c.CreatedOn.Date <= dtp_to.Value)
                                                 || (dtp_from.Checked && dtp_to.Checked == false && c.CreatedOn.Date == dtp_from.Value.Date)
                                                 || (dtp_from.Checked == false && dtp_to.Checked == false))
                                              orderby c.ExporterName
                                              select c).ToList();

            gv_list.DataSource = records;
            gv_list.Refresh();
        }

        private void gv_list_DoubleClick(object sender, EventArgs e)
        {
            Mst_ExporterView the_result = (Mst_ExporterView)gc_list.GetRow(gc_list.GetSelectedRows().FirstOrDefault());
            record_id = the_result.ExporterID;

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

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab == tabPage2)
            {
                if (record_id == null || record_id == "")
                {
                    TabControl.SelectedTab = tabPage1;
                    MessageBox.Show("Action failed. ", "Please select a Exporter Name first", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tabPage2.Enabled = false;
                }
                else { tabPage2.Enabled = true;
                    record_id2 = "";
                    load_list2();
                    do_load2();
                    tb_exporter_name2.Text = tb_exporter_name.Text;
                    
                }
            }
        }


        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        public string record_id2 = "";

        private void btn_close2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool do_save_record_verify2()
        {
            lbl_message2.Text = "";
            bool is_error = false;
            if (tb_address.Text.Trim() == "")
            {
                is_error = true;
                tb_address.Focus();
                lbl_message.Text = "Need to type Exporter Address";
            }

            return is_error;
        }
        string do_save_record2()
        {

            btn_delete2.Enabled = true;
            Linq_FumigationDataContext dc = new Linq_FumigationDataContext(Program.get_main_connection());
            Mst_Exporter_Address the_record = new Mst_Exporter_Address();

            try
            {
                if (do_save_record_verify2()) return "";

                if (record_id2 != "")
                {
                    the_record = (from c in dc.Mst_Exporter_Addresses where record_id2 == c.ExporterAddressID select c).FirstOrDefault();

                }
                else
                {
                    the_record = new Mst_Exporter_Address()
                    {

                        CreatedBy = Program.get_current_user_id(),
                        CreatedOn = DateTime.Now,
                        Active = true,
                        LastAction = Guid.NewGuid().ToString(),
                        ExporterAddressID = Guid.NewGuid().ToString(),
                        ExporterID=record_id,
                        ModifiedOn = DateTime.Now,
                        ModifiedBy = Program.get_current_user_id(),

                    };
                    dc.Mst_Exporter_Addresses.InsertOnSubmit(the_record);
                }

                //#region updatelog
                //HR_Staff log_obj = dc.GetChangeSet().Updates.OfType<HR_Staff>().FirstOrDefault();
                //if (log_obj != null)
                //{
                //    if (Controller.Controller_SystemLog.WirteUpdateLog(dc.HR_Staffs.GetModifiedMembers(log_obj).ToList(), record_id, Program.get_current_user_name()) == false)
                //        MessageBox.Show("Warning: System cannot write log file");
                //}
                //#endregion


                the_record.ExporterAddress = tb_address.Text;

                dc.SubmitChanges();

                if (AutoCloseAfterSave) this.DialogResult = DialogResult.Yes;
                MessageBox.Show("Record has been saved.", "Save Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (record_id2 == "new" || record_id2 == "")
                {
                    record_id2 = the_record.ExporterAddressID;

                }
                do_load2();
                load_list2();
                return "success";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Action failed. " + ex.Message, "SORRY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return ex.Message;
            }
        }
        void do_new2()
        {
            record_id2 = "";
            tb_exporter_name2.Text = "";
            tb_address.Text = "";

            // tb_remark.Text = "";
            tb_created_on2.Text = "";
            tb_modified_on2.Text = "";
            lbl_message2.Text = "";


            btn_delete2.Enabled = false;
            tb_address.Focus();
            load_list2();
        }

        void do_delete2()
        { // user access;
            if (MessageBox.Show("Are you sure you want to delete this record?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                      DialogResult.Yes)
            {
                Linq_FumigationDataContext dc = new Linq_FumigationDataContext(Program.get_main_connection());
                Mst_Exporter_Address the_record = new Mst_Exporter_Address();
                the_record = (from c in dc.Mst_Exporter_Addresses where c.Active == true && c.ExporterAddressID == record_id2 select c).FirstOrDefault();
                if (the_record == null) throw new Exception("System cannot find the record.");
                the_record.Active = false;
                the_record.ModifiedBy = Program.get_current_user_code();
                the_record.ModifiedOn = DateTime.Now;
                the_record.LastAction = Guid.NewGuid().ToString();
                dc.SubmitChanges();
                do_new2();
            }
        }

        void do_load2()
        {
            //if (theAccess.AllowSelect == false)
            //{
            //    MessageBox.Show("You don't have permission to view this record.", "Security Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            btn_delete2.Enabled = true;
            lbl_message2.Text = "";

            Linq_FumigationDataContext dc = new Linq_FumigationDataContext(Program.get_main_connection());
            Mst_Exporter_AddressView the_result = (from c in dc.Mst_Exporter_AddressViews where c.Active == true && c.ExporterID==record_id  && c.ExporterAddressID == record_id2 select c).FirstOrDefault();
            if ( record_id2 != "")
            {
                tb_address.Text = the_result.ExporterAddress;

                // tb_remark.Text = the_result.Remark;
                tb_created_on2.Text = string.Format("{1} on {0}", the_result.CreatedOn.ToString("dd/MM/yyyy hh:mm tt"), the_result.CreatedByCode);
                tb_modified_on2.Text = string.Format("{1} on {0}", the_result.ModifiedOn.ToString("dd/MM/yyyy hh:mm tt"), the_result.ModifiedByCode);




            }
            else { do_new2(); }
        }
        void load_list2()
        {
            Linq_FumigationDataContext dc = new Linq_FumigationDataContext(Program.get_main_connection());
            List<Mst_Exporter_AddressView> records = (from c in dc.Mst_Exporter_AddressViews
                                                      where c.Active == true && c.ExporterID==record_id
                                                 && ((tb_search2.Text == "") || (tb_search2.Text != "" &&
                                                 (c.ExporterAddress.Contains(tb_search2.Text)
                                                 )))
                                                 &&
                                                 ((dtp_from2.Checked && dtp_to2.Checked && c.CreatedOn.Date >= dtp_from2.Value && c.CreatedOn.Date <= dtp_to2.Value)
                                                 || (dtp_from2.Checked && dtp_to2.Checked == false && c.CreatedOn.Date == dtp_from2.Value.Date)
                                                 || (dtp_from2.Checked == false && dtp_to2.Checked == false))
                                              orderby c.ExporterAddress
                                              select c).ToList();

            gv_list2.DataSource = records;
            gv_list2.Refresh();
        }

        private void gv_list2_DoubleClick(object sender, EventArgs e)
        {
            Mst_Exporter_AddressView the_result = (Mst_Exporter_AddressView)gc_list2.GetRow(gc_list2.GetSelectedRows().FirstOrDefault());
            record_id2 = the_result.ExporterAddressID;

            do_load2();
        }

        private void btn_save2_Click(object sender, EventArgs e)
        {
            do_save_record2();
        }

        private void btn_new2_Click(object sender, EventArgs e)
        {
            do_new2();
        }

        private void btn_delete2_Click(object sender, EventArgs e)
        {
            do_delete2();
        }
        private void tb_search_TextChanged2(object sender, EventArgs e)
        {
            load_list2();
        }
        private void period_changed2(object sender, EventArgs e)
        {
            load_list2();
        }

    }
}
