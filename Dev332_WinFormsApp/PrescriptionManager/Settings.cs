using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrescriptionManager
{
    static class Settings
    {
        public static string AadInstance => ConfigurationManager.AppSettings["ida:AADInstance"];
        public static string Tenant => ConfigurationManager.AppSettings["ida:Tenant"];
        public static string ClientId => ConfigurationManager.AppSettings["ida:ClientId"];
        public static string GraphResourceId => ConfigurationManager.AppSettings["ida:GraphResourceId"];
        public static string GraphApiVersion => ConfigurationManager.AppSettings["ida:GraphApiVersion"];
        public static string GraphApiEndpoint => ConfigurationManager.AppSettings["ida:GraphApiEndpoint"];
        public static Uri RedirectUri => new Uri(ConfigurationManager.AppSettings["ida:RedirectUri"]);
        public static string Authority => String.Format(CultureInfo.InvariantCulture, AadInstance, Tenant);
    }
}
