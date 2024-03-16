using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_MDPC_Fumigation.Controller
{
    class Controller_Connection_String
    {
        
            public static decimal round_to_hunderd(decimal value)
            {
                return Math.Round(value / 100, 0) * 100;
            }
            public static string toDecimal(decimal value)
            {
                string value_string = Math.Round(value, 0).ToString();
                string result = "";
                if (value_string.Length <= 5)
                    return value.ToString("N0");
                else if (value_string.Length == 6)
                    return value_string[0].ToString() + "," + value_string[1].ToString() + value_string[2].ToString() + "," + value_string[3].ToString() + value_string[4].ToString() + value_string[5].ToString();
                else if (value_string.Length == 7)
                    return value_string[0].ToString() + value_string[1].ToString() + "," + value_string[2].ToString() + value_string[3].ToString() + "," + value_string[4].ToString() + value_string[5].ToString() + value_string[6].ToString();
                else if (value_string.Length == 8)
                    return value_string[0].ToString() + value_string[1].ToString() + value_string[2].ToString() + "," + value_string[3].ToString() + value_string[4].ToString() + "," + value_string[5].ToString() + value_string[6].ToString() + value_string[7].ToString();
                else if (value_string.Length == 9)
                    return value_string[0].ToString() + "" + value_string[1].ToString() + value_string[2].ToString() + value_string[3].ToString() + "," + value_string[4].ToString() + value_string[5].ToString() + "," + value_string[6].ToString() + value_string[7].ToString() + value_string[8].ToString();
                else if (value_string.Length == 10)
                    return value_string[0].ToString() + value_string[1].ToString() + "" + value_string[2].ToString() + value_string[3].ToString() + value_string[4].ToString() + "," + value_string[5].ToString() + value_string[6].ToString() + "," + value_string[7].ToString() + value_string[8].ToString() + value_string[9].ToString();
                return result;
            }
            public static string buildConnectionString(string serverName, string database, string user, string pass)
            {
                return String.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", serverName, database, user, pass);
            }


            public static List<string> getConnectionStringValue(string connection)
            {

                List<string> result = new List<string>();
                List<string> raws = connection.Split(';').ToList();
                foreach (string raw in raws)
                {
                    result.Add(raw.Split('=')[1]);
                }
                return result;
            }
        }
    
}
