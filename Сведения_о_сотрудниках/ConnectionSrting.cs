using System;
using System.Configuration;

namespace Сведения_о_сотрудниках
{
    class ConnectionSrting
    {
        public static string ConnStr
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Сведения_о_сотрудниках.Properties.Settings.ConnStr"].ConnectionString;
            }
        }
    }
}
