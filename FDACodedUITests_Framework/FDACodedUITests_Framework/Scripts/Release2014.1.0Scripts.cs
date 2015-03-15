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
    /// Summary description for Release2014
    /// </summary>
    [CodedUITest]
    public class Release2014_1_0 : FDASharePointScriptsBase
    {
        public Release2014_1_0()
        {
        }

        #region Test Initialize
        // Use TestInitialize to run code before running each test
        [TestInitialize()]
        public override void MyTestInitialize()
        {
            Console.WriteLine("Initialize \"Release 2014.1.0\" tests");
            base.MyTestInitialize();
        }
        #endregion

        #region Release 2014.1.0 regression test scripts
        [TestMethod]
        public void FDASpeakerForm()
        {
            try
            {
                throw new Exception("Test method not yet implemented.");
            }
            finally
            {

            }
        }

        [TestMethod]
        public void MySitesViewSelection()
        {
            try
            {
                throw new Exception("Test method not yet implemented.");
            }
            finally
            {

            }
        }

        [TestMethod]
        public void ContextualSearchScope()
        {
            try
            {
                throw new Exception("Test method not yet implemented.");
            }
            finally
            {

            }
        }
        #endregion

        #region Test Cleanup
        // Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public override void MyTestCleanup()
        {
            base.MyTestCleanup();
        }
        #endregion
    }
}
