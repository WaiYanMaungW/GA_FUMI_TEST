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
    public partial class frm_running_fcno : Form
    {
        public frm_running_fcno()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void frm_running_fcno_Load(object sender, EventArgs e)
        {
            load();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            do_save();
        }
        void load()
        { Linq_SystemDataContext dc = new Linq_SystemDataContext(Program.get_main_connection());
           Sys_RunningNo result = (from c in dc.Sys_RunningNos where c.RunningNoID == "1" && c.RunningNoCode== "FUMI" select c).FirstOrDefault();

            lab_fcno.Text= Controller.Controller_Running_No.GetNewRunningNo_Check("FUMI");
            tb_start_no.Text = result.RunningNoStart.ToString();
            tb_no_length.Text = result.RunningSequneceLength.ToString();
            tb_latest_no.Text = result.RunningSequence.ToString();
        }
        string do_save()
        {
            Linq_SystemDataContext dc = new Linq_SystemDataContext(Program.get_main_connection());
            Sys_RunningNo result = (from c in dc.Sys_RunningNos where c.RunningNoID == "1" && c.RunningNoCode == "FUMI" select c).FirstOrDefault();
            try
            { result.RunningNoStart = Convert.ToInt32(tb_start_no.Text);
            result.RunningSequneceLength = Convert.ToInt32(tb_no_length.Text);
            result.RunningSequence = Convert.ToInt32(tb_latest_no.Text);

            dc.SubmitChanges();
                MessageBox.Show("Record has been saved.", "Save Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                return "success"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Action failed. " + ex.Message, "SORRY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return ex.Message;
            }
           
        }
    }
}
