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
    /// These test methods are designed to perform UI testing for
    /// the "my.FDA.gov" functionality of the FDA SharePoint application.
    /// </summary>
    [CodedUITest]
    public class MyFDAGovScripts : FDASharePointScriptsBase
    {
        public MyFDAGovScripts()
        {
        }

        #region Test Initialize
        //Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public override void MyTestInitialize()
        {
            Console.WriteLine("Initialize \"my.FDA.gov\" tests");
            base.MyTestInitialize();
        }
        #endregion 

        #region my.FDA.gov regression test scripts
        // *********** TO-DO: Measure test execution speed for private member access **************
        //                          vs. public member access

        //[TestMethod]
        //public void MyFDAGov_PrivatePropAccess()
        //{
        //    try
        //    {
        //        homePage.LaunchBrowserAndNavToFDASharePointHomePage();
        //        homePage.NavToMyFDAGovPage();

        //        // Move to "My Content" page within my.FDA.gov
        //        myFDAGovHomePage.NavToMyContentPage();

        //        // Upload a document to the Shared Documents library
        //        myFDAGovMyContentPage.UploadSharedDocument();
        //        myFDAGovMyContentPage.AssertDocAddedToSharedDocuments();
        //        myFDAGovMyContentPage.DeleteSharedDocument();

        //        // Upload a document to the Personal Documents library
        //        myFDAGovMyContentPage.UploadPersonalDocument();
        //        myFDAGovMyContentPage.AssertDocAddedToPersonalDocuments();
        //        myFDAGovMyContentPage.DeletePersonalDocument();

        //        // Create a document from the Shared Documents library
        //        myFDAGovMyContentPage.AddSharedDocument();
        //        myFDAGovMyContentPage.AssertDocAddedToSharedDocuments();
        //        myFDAGovMyContentPage.DeleteSharedDocument();

        //        // Create a document from the Personal Documents library
        //        myFDAGovMyContentPage.AddPersonalDocument();
        //        myFDAGovMyContentPage.AssertDocAddedToPersonalDocuments();
        //        myFDAGovMyContentPage.DeletePersonalDocument();
        //    }
        //    finally
        //    {
        //        // Close browser
        //        homePage.CloseBrowser();
        //    }
        //}

        // *********** TO-DO: Measure test execution speed for private member access **************
        //                          vs. public member access

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            "|DataDirectory|\\TestData\\UploadDocData.csv", "UploadDocData#csv", DataAccessMethod.Sequential),
        DeploymentItem("FDACodedUITests_Framework\\TestData\\UploadDocData.csv"), TestMethod]
        public void MyFDAGov_PublicPropAccess()
        {
            try
            {
                // Launch browser
                Browser.LaunchAndNavigate(AppConfig.GetValue("URL"));

                HomePage.Login(
                    username: AppConfig.GetValue("Username"),
                    password: AppConfig.GetValue("Password")
                );
                HomePage.NavToMyFDAGovPage();

                // Move to "My Content" page within my.FDA.gov
                MyFDAGovHomePage.NavToMyContentPage();

                // Upload a document to the Shared Documents library
                MyFDAGovMyContentPage.UploadSharedDocument(
                    docName: Bind("FilePath")    
                );
                MyFDAGovMyContentPage.AssertDocAddedToSharedDocuments();
                MyFDAGovMyContentPage.DeleteSharedDocument();

                // Upload a document to the Personal Documents library
                MyFDAGovMyContentPage.UploadPersonalDocument(
                    docName: Bind("FilePath")    
                );
                MyFDAGovMyContentPage.AssertDocAddedToPersonalDocuments();
                MyFDAGovMyContentPage.DeletePersonalDocument();
                
                // Create a document from the Shared Documents library
                MyFDAGovMyContentPage.AddSharedDocument();
                MyFDAGovMyContentPage.AssertDocAddedToSharedDocuments();
                MyFDAGovMyContentPage.DeleteSharedDocument();

                // Create a document from the Personal Documents library
                MyFDAGovMyContentPage.AddPersonalDocument();
                MyFDAGovMyContentPage.AssertDocAddedToPersonalDocuments();
                MyFDAGovMyContentPage.DeletePersonalDocument();
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
