using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System.Diagnostics;

namespace FDACodedUITests_Framework.Library
{
    /// <summary>
    /// Generic Browser related utilities/APIs that can be used
    /// across projects. 
    /// 
    /// No application-specific content.
    /// </summary>
    public class Browser
    {
        static BrowserWindow browser;

        /// <summary>
        /// Launch Browser
        /// </summary>
        public static void Launch()
        {
            browser = BrowserWindow.Launch();
            Maximize();
        }

        /// <summary>
        /// Navigate to specified URL
        /// </summary>
        /// <param name="urlString">The url to navigate</param>
        public static void Navigate(string urlString)
        {
            browser.NavigateToUrl(new System.Uri(urlString));
        }

        /// <summary>
        /// Launch and navigate to specified URL
        /// </summary>
        /// <param name="urlString">The url to navigate</param>
        public static void LaunchAndNavigate(string urlString)
        {
            Launch();
            Maximize();
            Navigate(urlString);
        }

        /// <summary>
        /// Close the browser
        /// </summary>
        public static void Close()
        {
            browser.Close();
        }

        /// <summary>
        /// Close all open IE Browser processes
        /// </summary>
        public static void CloseAllBrowsers()
        {
            Process[] appWindows = Process.GetProcessesByName("iexplore");

            foreach (Process window in appWindows)
            {
                window.Kill();
            }
        }

        /// <summary>
        /// Maximize the browser window
        /// </summary>
        public static void Maximize()
        {
            browser.Maximized = true;
        }
    }
}
