using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GA_MDPC_Fumigation.LINQ;

namespace GA_MDPC_Fumigation.Controller
{
    class Controller_Running_No
    {
        public static string GetNewRunningNo_Check(string RunningNoCode)
        {
            string new_running_no = "";
            try
            {
                Linq_SystemDataContext dc_sys = new Linq_SystemDataContext(Program.get_main_connection());
                Sys_RunningNo the_running_no = (from c in dc_sys.Sys_RunningNos where c.RunningNoCode == RunningNoCode select c).FirstOrDefault();
                if (the_running_no == null) return "No Running Code";
                the_running_no.RunningSequence = the_running_no.RunningSequence + 1;
                string running_number_length = "D" + the_running_no.RunningSequneceLength.ToString();  //D for Standard numeric format strings

                DateTime current = DateTime.Now;
                the_running_no.RunningNoStart = current.Year - 2000;


                new_running_no = the_running_no.RunningNoStart + "/" + the_running_no.RunningSequence.ToString(running_number_length);

               
                return new_running_no;
            }
            catch (Exception ex)
            {
                return "ERR";
            }

        }
        public static string GetNewRunningNo_Generate(string RunningNoCode)
        {
            string new_running_no = "";
            try 
            {
                Linq_SystemDataContext dc_sys = new Linq_SystemDataContext(Program.get_main_connection());
                Sys_RunningNo the_running_no = (from c in dc_sys.Sys_RunningNos where c.RunningNoCode == RunningNoCode select c).FirstOrDefault();
                if (the_running_no == null) return "No Running Code";
                the_running_no.RunningSequence = the_running_no.RunningSequence + 1;
                string running_number_length = "D" + the_running_no.RunningSequneceLength.ToString();

                DateTime current = DateTime.Now;
                the_running_no.RunningNoStart = current.Year-2000;


                new_running_no = the_running_no.RunningNoStart + "/"+ the_running_no.RunningSequence.ToString(running_number_length);

                dc_sys.SubmitChanges(); //add only save
                return new_running_no;
            }
            catch (Exception ex)
            {
                return "ERR";
            }

        }

    }
}
