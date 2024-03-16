using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GA_MDPC_Fumigation.LINQ;

namespace GA_MDPC_Fumigation.UI_Module.System_Main
{
    public partial class frm_system_log : Form
    {
        public frm_system_log()
        {
            InitializeComponent();
        }
         public string record_id;
        Linq_SystemDataContext dc = new Linq_SystemDataContext(Program.get_main_connection());

        void load_list()
        {

            try
            {
                gc_log.DataSource = (from c in dc.Sys_Logs
                                     where c.RecordID == tb_record_id.Text
                                     orderby
                                         c.LogDateTime descending
                                     select c).ToList();

                if (gv_list.SelectedRowsCount >= 0)
                {

                    Sys_Log the_result = (Sys_Log)gc_list.GetRow(gc_list.GetSelectedRows().FirstOrDefault());
                    load_detail(the_result.SystemLogID);
                }
                else
                {
                    MessageBox.Show("There is no log before. Sorry.");
                    this.Close();
                }
                //return "success";
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is no log before. " + ex.Message, "No Logs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               // return ex.Message;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void load_detail(string logID)
        {

            gc_logdetail.DataSource = (from c in dc.Sys_Log_Items where c.SystemLogID == logID && c.FieldName != "ModifiedOn" && c.FieldName != "ModifiedBy" && c.FieldName != "LastAction" select c).ToList();
        }

        private void tb_record_id_TextChanged(object sender, EventArgs e)
        {
            load_list();
        }

        private void frm_system_log_Load(object sender, EventArgs e)
        {
            tb_record_id.Text = record_id;
        }
        private void gc_list_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            Sys_Log the_result = (Sys_Log)gc_list.GetRow(gc_list.GetSelectedRows().FirstOrDefault());
            load_detail(the_result.SystemLogID);
        }
    }
}
