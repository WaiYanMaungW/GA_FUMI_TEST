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

namespace GA_MDPC_Fumigation.UI_Module.System_Main
{
    public partial class frm_password_change : Form
    {
        public frm_password_change()
        {
            InitializeComponent();
        }
        private void frm_password_change_Load(object sender, EventArgs e)
        {
            tb_user_name.Text = Program.get_current_user_code();
            tb_old_Password.Focus();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void check_password()
        {
            Linq_SystemDataContext dc = new Linq_SystemDataContext(Program.get_main_connection());

            string password = Controller.Controller_AES.Encrypt(tb_old_Password.Text, "Log In");

            SysUser log_in_user = (from c in dc.SysUsers where c.PasswordPharse == "Log In" && c.UserCode == tb_user_name.Text && c.Active == true select c).FirstOrDefault();
            if (log_in_user == null)
            {
                throw new Exception("Incorrect User Name");
            }
            else if (tb_old_Password.Text != Controller.Controller_AES.Decrypt(log_in_user.Password, log_in_user.PasswordPharse))
            {
                tb_old_Password.Text = ""; tb_old_Password.Focus();
                throw new Exception("Incorrect Password");
            }

            else if (tb_old_Password.Text == Controller.Controller_AES.Decrypt(log_in_user.Password, log_in_user.PasswordPharse))
            {
                // this.Hide();
                //  Properties.Settings.Default["Current_User"] = log_in_user.UserCode;
                // Properties.Settings.Default["Current_User_ID"] = log_in_user.UserID;
                //  Properties.Settings.Default["Current_UserName"] = log_in_user.UserName;

                //Properties.Settings.Default["BranchID"] = log_in_user.DepartmentID;
                //Join with staff table
                //Linq_HRDataContext dc_hr = new Linq_HRDataContext(Program.get_main_connection());
                //HR_Staff the_staff = (from c in dc_hr.HR_Staffs where c.UserID == login_user.UserID && c.Active == true select c).FirstOrDefault();
                //if (the_staff != null)
                //    Program.set_current_staff_id(the_staff.StaffID);
                //else
                //    Program.set_current_staff_id("");



                //   log_in_user.LastLogin = DateTime.Now;
                log_in_user.Password = Controller.Controller_AES.Encrypt(tb_new_Password.Text, "Log In");
                log_in_user.ModifiedOn = DateTime.Now;
                dc.SubmitChanges();
                MessageBox.Show(" Please log in again.", "Password is successfully changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }
        }

        private void btn_password_save_Click(object sender, EventArgs e)
        {
            check_password();
        }
    }
}
