using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GA_MDPC_Fumigation.LINQ;

namespace GA_MDPC_Fumigation.UI_Module.Log_In
{
    public partial class frm_Log_In : DevExpress.XtraEditors.XtraForm
    {
        public frm_Log_In()
        {
            InitializeComponent();
        }
        private void frm_Log_In_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_log_in_Click(object sender, EventArgs e)
        {
            log_in();
        }

        void log_in()
        {
            try
            {
                Linq_SystemDataContext dc = new Linq_SystemDataContext(Program.get_main_connection());

                string password = Controller.Controller_AES.Encrypt(tb_Password.Text, "Log In");

                SysUser log_in_user = (from c in dc.SysUsers where c.PasswordPharse == "Log In" && c.UserCode == tb_user_name.Text && c.Active == true select c).FirstOrDefault();
                if (log_in_user == null)
                {
                    throw new Exception("Incorrect User Name");
                }

                else if (tb_Password.Text != Controller.Controller_AES.Decrypt(log_in_user.Password, log_in_user.PasswordPharse))
                {
                    tb_Password.Text = ""; tb_Password.Focus();
                    throw new Exception("Incorrect Password");
                }
                else if (tb_Password.Text == Controller.Controller_AES.Decrypt(log_in_user.Password, log_in_user.PasswordPharse))
                {
                    this.Hide();
                    Properties.Settings.Default["Current_User"] = log_in_user.UserCode;
                    Properties.Settings.Default["Current_User_ID"] = log_in_user.UserID;
                    Properties.Settings.Default["Current_UserName"] = log_in_user.UserName;
                    //Properties.Settings.Default["BranchID"] = log_in_user.DepartmentID;
                    //Join with staff table
                    //Linq_HRDataContext dc_hr = new Linq_HRDataContext(Program.get_main_connection());
                    //HR_Staff the_staff = (from c in dc_hr.HR_Staffs where c.UserID == login_user.UserID && c.Active == true select c).FirstOrDefault();
                    //if (the_staff != null)
                    //    Program.set_current_staff_id(the_staff.StaffID);
                    //else
                    //    Program.set_current_staff_id("");

                    UI_Module.Main.frm_main _root_form = new UI_Module.Main.frm_main();
                    _root_form.WindowState = FormWindowState.Maximized;
                    //_root_form.FormBorderStyle = FormBorderStyle.Sizable;
                    log_in_user.LastLogin = DateTime.Now;
                    dc.SubmitChanges();


                    #region Get Current User Role Program
                    //Program.current_role_programs = (from c in dc.SysRoleProgramViews where c.SysRoleID == login_user.SystemRoleID select c).ToList();
                    #endregion
                    _root_form.ShowDialog();
                    //after close
                    tb_Password.Text = "";
                    tb_user_name.Text = "";
                    //tb_user_id.Focus();
                    this.ActiveControl = tb_user_name;

                    this.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //  lbl_message.Text = ex.Message;
            }


        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            bool baseResult = base.ProcessCmdKey(ref msg, keyData);

            if (keyData == (Keys.Enter))// enter press
            {
                log_in();
                return true;
            }

            return baseResult;


        }
    }
}