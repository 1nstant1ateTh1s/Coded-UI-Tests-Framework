using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace FDACodedUITests_Framework.Config
{
    public class AppConfig
    {
        /// <summary>
        /// Get the value corresponding to the key from App.config settings
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
            //return ConfigurationSettings.AppSettings[key]; ** - Obsolete version **
        }
    }
}
