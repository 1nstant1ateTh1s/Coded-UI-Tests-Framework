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
using FDACodedUITests_Framework.Library;
using FDACodedUITests_Framework.Config;

namespace FDACodedUITests_Framework.Scripts
{
    /// <summary>
    /// Base test methods designed to perform UI testing for
    /// the FDA SharePoint application.
    /// </summary>
    [CodedUITest]
    public class FDASharePointScriptsBase : FDASharePointUITest
    {
        public FDASharePointScriptsBase()
        {
        }

        #region Additional test attributes
        //Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public virtual void MyTestInitialize()
        {
            Browser.CloseAllBrowsers();
        }

        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public virtual void MyTestCleanup()
        {
            Browser.CloseAllBrowsers();
        }
        #endregion

        #region Helper methods
        /// <summary>
        /// Helper method to simplify calls to the TestContext.DataRow indexer
        /// to get the TestData data values.
        /// </summary>
        /// <param name="columnName">The name of the column to retrieve.</param>
        /// <returns>The specified row value.</returns>
        public string Bind(string columnName)
        {
            return TestContext.DataRow[columnName].ToString();
        }
        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
