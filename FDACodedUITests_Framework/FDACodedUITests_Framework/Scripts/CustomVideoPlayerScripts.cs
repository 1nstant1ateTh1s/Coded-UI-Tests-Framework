using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using FDACodedUITests_Framework.Config;
using FDACodedUITests_Framework.Library;

namespace FDACodedUITests_Framework.Scripts
{
    /// <summary>
    /// These test methods are designed to perform UI testing for
    /// the "Custom Video Player" functionality of the FDA SharePoint application.
    /// </summary>
    [CodedUITest]
    public class CustomVideoPlayerScripts : FDASharePointScriptsBase
    {
        public CustomVideoPlayerScripts()
        {
        }

        #region Test Initialize
        //Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public override void MyTestInitialize()
        {
            Console.WriteLine("Initialize \"Custom Video Player\" tests");
            base.MyTestInitialize();
        }
        #endregion

        #region Custom Video Player regression test scripts
        [TestMethod]
        public void AddCustomVideoPlayer()
        {
            try
            {
                // Launch browser
                Browser.LaunchAndNavigate(AppConfig.GetValue("URL"));

                HomePage.Login(
                    username: AppConfig.GetValue("Username"),
                    password: AppConfig.GetValue("Password")
                );

            }
            finally
            {
                // Close browser
                //HomePage.CloseBrowser();
            }
        }
        #endregion

        #region Test Cleanup
        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public override void MyTestCleanup()
        {
            base.MyTestCleanup();
        }
        #endregion
    }
}
