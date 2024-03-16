using GA_MDPC_Fumigation.Controller;
using GA_MDPC_Fumigation.UI_Module.Log_In;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GA_MDPC_Fumigation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            // Application.Run(new frm_main());
            Application.Run(new frm_Log_In());
        }


        public static string get_current_user_id()
        {
            return Properties.Settings.Default["Current_User_ID"].ToString();
        }
        public static string get_current_user_code()
        {
            return Properties.Settings.Default["Current_User"].ToString();
        }
        public static string get_current_user_name()
        {
            return Properties.Settings.Default["Current_UserName"].ToString();
        }

        public static string get_counter_id()
        {
            return Properties.Settings.Default["CounterID"].ToString();
        }
        static string _staff_id = "";
        public static string get_current_staff_id()
        {
            return _staff_id;
        }
        public static void set_current_staff_id(string value)
        {
            _staff_id = value;
        }
        public static string get_current_program_version()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
        public static string get_main_connection()
        {
            string result;
            try
            {
                return result = Controller_AES.Decrypt(Program.get_program_registery_value("GA_MDPC_FUMIGATION"), "GA_Connect");
            }
            catch
            {
                return result = Properties.Settings.Default["GA_MDPC_FUMIGATION"].ToString();

            }


        }
        public static string get_image_connection()
        {
            string result;
            try
            {
                return result = Controller_AES.Decrypt(Program.get_program_registery_value("GA_MDPC_FUMIGATION_IMAGE"), "GA_Connect");
            }
            catch
            {
                return result = Properties.Settings.Default["GA_MAIN2ConnectionString"].ToString();

            }

        }
        public static string get_branch_id()
        {
            return Properties.Settings.Default["BranchID"].ToString();
        }

        static bool show_window_seperate = false;
        public static void set_show_window_status(bool check)
        {
            show_window_seperate = check;
        }

        public static bool get_show_window_status()
        {
            return show_window_seperate;
        }


        static string _language = "en-SG";
        public static void SetLocalization(string code)
        {
            _language = code;
        }
        public static string GetLocalization()
        {
            return _language;
        }
        #region Computer

        //public static SysClient _currentComputer;
        //public static SysClient CurrentComputer()
        //{
        //    return _currentComputer;
        //}

        #endregion

        #region Company

        //public static SysCompany _company;
        //public static SysCompany CurrentCompany()
        //{
        //    if (_company == null)
        //    {
        //        Linq_SystemDataContext dc = new Linq_SystemDataContext(Program.get_main_connection());
        //        _company = (from c in dc.SysCompanies select c).FirstOrDefault();


        //    }



        //    return _company;
        //}
        #endregion



        #region Record Linker  ***************<<<<
        public static string get_program_registery_path()
        {
            const string keyName = "HKEY_CURRENT_USER" + "\\Software" + "\\GA_FUMIGATION_CERTIFICATE";

            //try
            //{
            //    if (Properties.Settings.Default["ProjectCode"].ToString() != "")
            //        return keyName + "\\" + Properties.Settings.Default["ProjectCode"].ToString();
            //}
            //catch (Exception ex)
            //{

            //}

            return keyName;
        }

        public static string get_program_registery_value(string property_name)
        {
            try
            {
                return Registry.GetValue(get_program_registery_path(), property_name, RegistryValueKind.String).ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public static void set_program_registery_value(string property_name, string property_value)
        {
            try
            {
                Registry.SetValue(get_program_registery_path(), property_name, property_value);
            }
            catch (Exception ex)
            {

            }
        }


        #endregion

        #region Message Box
        //public static void ShowSysMessage(string message)
        //{
        //    UserInterface.Module_Common.SSMessageBox.frm_message the_form = new UserInterface.Module_Common.SSMessageBox.frm_message();
        //    the_form.lbl_message.Text = message;
        //    if (Program.get_show_window_status()) { the_form.Show(); } else { the_form.ShowDialog(); }
        //}
        //public static string ShowSysInputMessage(string message)
        //{
        //    UserInterface.Module_Common.SSMessageBox.frm_input_message the_form = new UserInterface.Module_Common.SSMessageBox.frm_input_message();
        //    the_form.lbl_message.Text = message;
        //    if (the_form.ShowDialog() == DialogResult.Yes)
        //        return the_form.tb_input_message.Text;
        //    else
        //        return "";
        //}
        #endregion



        #region connection_string_change

        public static void Conncetion_string_add()
        {
            try
            {
                //MP_HR.UI_Module.System_Main.AppSetting app_setting = new MP_HR.UI_Module.System_Main.AppSetting();
                //app_setting.Save_Connection_String("MP_HR.Properties.Settings.GA_MAINConnectionString", Controller_AES.Decrypt(Program.get_program_registery_value("GA_MDPC_HR"), "GA_Connect"));
                //app_setting.Save_Connection_String("MP_HR.Properties.Settings.GA_MAIN2ConnectionString", Controller_AES.Decrypt(Program.get_program_registery_value("GA_MDPC_HR_IMAGE"), "GA_Connect"));




                Cursor.Current = Cursors.WaitCursor;
                string SourcePath = @"C:\Program Files (x86)\Microsoft\ClientCertificate\Client1";
                string DestinationPath = @"D:\MDPC-Fumigation\MDPC_FUMIGATION";


                //Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(SourcePath, "*",
                    SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(SourcePath, "*.*",
                    SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath), true);

                Cursor.Current = Cursors.Default;



            }
            catch (Exception ex)
            {

            }
        }


        public static void Conncetion_string_delete()
        {
            try
            {
                //MP_HR.UI_Module.System_Main.AppSetting app_setting = new MP_HR.UI_Module.System_Main.AppSetting();
                //String connection_string_new = String.Format("DataSourse={0};Initial Catalog={1};User ID={2};Password={3};", "0", "0", "0", "0");
                //app_setting.Save_Connection_String("MP_HR.Properties.Settings.GA_MAINConnectionString", connection_string_new);
                //app_setting.Save_Connection_String("MP_HR.Properties.Settings.GA_MAIN2ConnectionString", connection_string_new);


                Cursor.Current = Cursors.WaitCursor;
                string SourcePath = @"C:\Program Files (x86)\Microsoft\ClientCertificate\Client1";
                string DestinationPath = @"D:\MDPC-Fumigation\MDPC_FUMIGATION";

                //Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(SourcePath, "*",
                    SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(SourcePath, "*.*",
                    SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath), true);

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {

            }
        }


        #endregion
    }
}
