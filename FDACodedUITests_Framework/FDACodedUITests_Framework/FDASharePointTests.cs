using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITest.Extension.Silverlight;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace FDACodedUITests_REFACTORED
{
    /// <summary>
    /// These test methods are designed to perform UI testing for
    /// the FDA SharePoint application.
    /// </summary>
    [CodedUITest]
    public class FDASharePointTests : FDASharePointUITest
    {
        public FDASharePointTests()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        }

        #region Regression Test Methods

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void MyFDAGov()
        {
            try
            {
                homePage.LaunchBrowserAndNavToFDASharePointHomePage();
                homePage.NavToMyFDAGovPage();

                // Move to "My Content" page within my.FDA.gov
                myFDAGovHomePage.NavToMyContentPage();

                // Upload a document to the Shared Documents library
                myFDAGovMyContentPage.UploadSharedDocument();
                myFDAGovMyContentPage.AssertDocAddedToSharedDocuments();
                myFDAGovMyContentPage.DeleteSharedDocument();

                // Upload a document to the Personal Documents library
                myFDAGovMyContentPage.UploadPersonalDocument();
                myFDAGovMyContentPage.AssertDocAddedToPersonalDocuments();
                myFDAGovMyContentPage.DeletePersonalDocument();

                // Create a document from the Shared Documents library
                myFDAGovMyContentPage.AddSharedDocument();
                myFDAGovMyContentPage.AssertDocAddedToSharedDocuments();
                myFDAGovMyContentPage.DeleteSharedDocument();

                // Create a document from the Personal Documents library
                myFDAGovMyContentPage.AddPersonalDocument();
                myFDAGovMyContentPage.AssertDocAddedToPersonalDocuments();
                myFDAGovMyContentPage.DeletePersonalDocument();
            }
            finally
            {
                // Close browser
                homePage.CloseBrowser();
            }
        }

        #endregion

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

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
