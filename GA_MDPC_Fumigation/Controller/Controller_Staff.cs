using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GA_MDPC_Fumigation.Fumigation.LINQ;

namespace MP_HR.Controller
{
    class Controller_Staff
    {
        public static (string, string,string) Load_staff_name(string staff_id)
        {
            string name = "";
            string myanmar_name = "";
            string nick_name = "";
            LINQ_HRDataContext dc = new LINQ_HRDataContext(Program.get_main_connection());
            HR_StaffView the_result = (from c in dc.HR_StaffViews where c.Active == true && c.StaffID == staff_id select c).FirstOrDefault();
            if (staff_id != "")
            {
                name = the_result.StaffName;
                myanmar_name = the_result.StaffName_Myanmar;
                nick_name = the_result.NickName;
                //record_staf_assign_id = the_result.StaffAssignID;
            }
            else
            {
                name = "";
                myanmar_name = "";
                nick_name = "";
            }

            return (name,myanmar_name, nick_name);
        }

    }
}
