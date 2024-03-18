using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ISM_HomePage
{
    public class CommonLogic
    {
        public static String Application(String paramName)
        {
            String tmpS = String.Empty;
            try
            {
                tmpS = ConfigurationManager.ConnectionStrings[paramName].ToString();
                if (tmpS == null)
                {
                    tmpS = string.Empty;
                }
            }
            catch
            {
                tmpS = String.Empty;
            }
            return tmpS;
        }

        public static bool ApplicationBool(String paramName)
        {
            String tmpS = ConfigurationManager.ConnectionStrings[paramName].ToString();
            if (tmpS != null)
            {
                tmpS = tmpS.ToUpperInvariant();
            }
            if (tmpS == "TRUE" || tmpS == "YES" || tmpS == "1")
            {
                return true;
            }
            return false;
        }
    }
}