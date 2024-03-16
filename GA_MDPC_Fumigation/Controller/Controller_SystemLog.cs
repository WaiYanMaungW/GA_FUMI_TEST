using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using GA_MDPC_Fumigation.LINQ;
namespace GA_MDPC_Fumigation.Controller
{
  public  class Controller_SystemLog
    {
        public static bool WirteUpdateLog(List<ModifiedMemberInfo> updated_fields, string record_id, string action_by)
        {
            try
            {
                Linq_SystemDataContext dc = new Linq_SystemDataContext(Program.get_main_connection());
                Sys_Log log = new Sys_Log()
                {
                    LogBy = action_by,
                    LogDateTime = DateTime.Now,
                    RecordID = record_id,
                    Remark = "",
                    SystemLogID = Guid.NewGuid().ToString()
                };
                dc.Sys_Logs.InsertOnSubmit(log);

                List<Sys_Log_Item> log_items = new List<Sys_Log_Item>();
                foreach (ModifiedMemberInfo memberInfo in updated_fields)
                {
                    Sys_Log_Item new_item = new Sys_Log_Item()
                    {
                        SystemLogID = log.SystemLogID,
                        SystemLogItemID = Guid.NewGuid().ToString(),
                        FieldName = memberInfo.Member.Name
                    };
                    try
                    {
                        new_item.NewValue = memberInfo.CurrentValue.ToString();
                    }
                    catch (Exception ex) { new_item.NewValue = ""; }

                    try
                    {
                        new_item.OldValue = memberInfo.OriginalValue.ToString();
                    }
                    catch (Exception ex) { new_item.OldValue = ""; }
                    log_items.Add(new_item);
                }

                dc.Sys_Log_Items.InsertAllOnSubmit(log_items);
                dc.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
    }
}
