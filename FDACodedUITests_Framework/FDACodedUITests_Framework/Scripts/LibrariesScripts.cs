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
    /// the basic SharePoint "Libraries" functionality of the FDA SharePoint application.
    /// </summary>
    [CodedUITest]
    public class LibrariesScripts : FDASharePointScriptsBase
    {
        public LibrariesScripts()
        {
        }

        #region Test Initialize
        // Use TestInitialize to run code before running each test
        [TestInitialize()]
        public override void MyTestInitialize()
        {
            Console.WriteLine("Initialize basic SharePoint \"Libraries\" tests");
            base.MyTestInitialize();
        }
        #endregion

        #region SharePoint "Libraries" regression test scripts
        [TestMethod()]
        public void FDASharePointLibraries()
        {
            try
            {
                CreateDocumentLibrary();

                //HomePage = null;

                UploadToLibrary();

                //// Launch browser
                //Browser.LaunchAndNavigate(AppConfig.GetValue("URL"));

                //// Login
                //HomePage.Login(
                //    username: AppConfig.GetValue("Username"),
                //    password: AppConfig.GetValue("Password")
                //);

                //// Test creation of new Document Library
                //CreateNewLibrary();

                //// 
                //UploadToSharedDocuments();

                // 

                // 

                // 

            }
            finally
            {
                // Cleanup

            }
        }

        [TestCategory("SharePoint Libraries"),
        TestMethod()]
        public void CreateDocumentLibrary()
        {
            try
            {
                // Launch browser
                Browser.LaunchAndNavigate(AppConfig.GetValue("URL"));

                // Login
                HomePage.Login(
                    username: AppConfig.GetValue("Username"),
                    password: AppConfig.GetValue("Password")
                );

                //Playback.PlaybackError += Playback_PlaybackError;
                //Playback.PlaybackError += CreateDocumentLibrary_PlaybackError;
                //Playback.PlaybackError -= Playback_PlaybackError;
                Playback.PlaybackError += new EventHandler<PlaybackErrorEventArgs>(Playback_PlaybackError);
                //Playback.PlaybackSettings.ContinueOnError = true;

                // Create new Document Library
                //HomePage.CreateNewDocumentLibrary("New Library TEST", 
                //    LibraryTemplateTypes.MICROSOFT_WORD_DOCUMENT);
                HomePage.CreateNewDocumentLibrary("New Library TEST");

                // Give the browser time to finish processing any on-going operations
                Playback.Wait(3000);

                // Verify there were no errors creating the new library
                //try
                //{
                    //HomePage.AssertNoSilverlightErrorOnCreation();
                //}
                //catch (AssertFailedException assertEx)
                //{
                //    var er = assertEx;

                //}

                // Delete new Document Library
                DocumentLibrariesPage.DeleteDocumentLibrary();
            }
            catch (Exception ex)
            {
                //Playback.PlaybackError += CreateDocumentLibrary_PlaybackError;

                var msg = ex.Message;
                if (msg.Contains("the specified title already exists"))
                {
                    // A library with the specified name already exists

                    //Playback.PlaybackError += CreateDocumentLibrary_PlaybackError;
                    throw new PlaybackFailureException(msg);
                }
                else if (msg.Contains("newer version of Windows"))
                {
                    // This error still creates the new library, but prevents 
                    // the new library from automatically opening up

                    //Playback.PlaybackError += Playback_PlaybackError;
                    throw new PlaybackFailureException(msg);
                    //throw ex;
                }
                else
                {
                    //throw ex; // Pass along any unknown errors

                    throw new PlaybackFailureException("Sample playback failure");
                }
            }
            finally
            {
                //Playback.PlaybackError -= Playback_PlaybackError;

                // Give the browser time to finish processing any on-going operations
                Playback.Wait(5000);

                // Cleanup
                //Browser.CloseAllBrowsers();
            }
        }

        static void Playback_PlaybackError(object sender, PlaybackErrorEventArgs e)
        {
            //throw new NotImplementedException();

            string errMsg = e.Error.Message;

        }

        void CreateDocumentLibrary_PlaybackError(object sender, PlaybackErrorEventArgs e)
        {
            string errMsg = e.Error.Message;
            if (errMsg.Contains("the specified title already exists"))
            {
                e.Result = PlaybackErrorOptions.Retry;

            }
            else if (errMsg.Contains("newer version of Windows"))
            {
                e.Result = PlaybackErrorOptions.Skip;

            }
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\TestData\\UploadToSharedDocumentsData.csv",
            "UploadToSharedDocumentsData#csv", DataAccessMethod.Sequential),
        DeploymentItem("FDACodedUITests_Framework\\TestData\\UploadToSharedDocumentsData.csv"), 
        TestCategory("SharePoint Libraries"),
        TestMethod()]
        public void UploadToLibrary()
        {
            try
            {
                // Launch browser
                Browser.LaunchAndNavigate(AppConfig.GetValue("URL"));

                // Login
                HomePage.Login(
                    username: AppConfig.GetValue("Username"),
                    password: AppConfig.GetValue("Password")
                );

                // Navigate to "Shared Documents" library
                HomePage.ViewAllSiteContent();
                AllSiteContentPage.OpenSharedDocumentsLibrary();

                // Upload test documents (Word, Excel, and PDF documents)
                DocumentLibrariesPage.UploadDocument(
                    docName: Bind("FilePath")    
                );

                // Verify document was uploaded successfully by passing the name of
                // the list item to search for
                DocumentLibrariesPage.AssertItemAddedToLibrary(
                    itemName: Bind("ExpectedFileName")    
                );

                // Delete test document by specifying the name of the list item to 
                // target for deletion
                DocumentLibrariesPage.DeleteDocument(
                    itemName: Bind("ExpectedFileName")
                );

            }
            //catch (Exception ex)
            //{

            //}
            finally
            {
                // Cleanup
                //Browser.CloseAllBrowsers();
            }
        }

        [TestCategory("SharePoint Libraries"), 
        TestMethod()]
        public void AddWordDocToLibrary()
        {
            try
            {
                // Launch browser
                Browser.LaunchAndNavigate(AppConfig.GetValue("URL"));

                // Login
                HomePage.Login(
                    username: AppConfig.GetValue("Username"),
                    password: AppConfig.GetValue("Password")
                );

                // 


                // 

            }
            finally
            {

            }
        }

        [TestMethod()]
        public void AddToLibrary()
        {
            try
            {
                // Launch browser
                Browser.LaunchAndNavigate(AppConfig.GetValue("URL"));

                // Login
                HomePage.Login(
                    username: AppConfig.GetValue("Username"),
                    password: AppConfig.GetValue("Password")
                );

                // Navigate to "Shared Documents" library
                HomePage.ViewAllSiteContent();
                AllSiteContentPage.OpenSharedDocumentsLibrary();

                // Create new documents 


                // Verify document was added successfully

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
            var outcome = TestContext.CurrentTestOutcome;
            var testNm = TestContext.TestName;

            base.MyTestCleanup();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// 
        /// </summary>
        private void CreateNewLibrary()
        {
            try
            {
                // Create new Document Library
                HomePage.CreateNewDocumentLibrary("New Library TEST");
                //HomePage.CreateNewDocumentLibrary("New Library TEST 2");

                // Verify there were no errors creating the new library
                HomePage.AssertNoSilverlightErrorOnCreation();

                //var test4 = HomePage.FDASharePointBrowser.AddGalleryFrame.AddGalleryDocument
                //    .AddGallerySilverlightCustom.SilverlightPage.UITopScrollViewerPane.UIErrorMessage.TryFind();
                //var test5 = HomePage.FDASharePointBrowser.AddGalleryFrame.AddGalleryDocument
                //    .AddGallerySilverlightCustom.SilverlightPage.UITopScrollViewerPane.UIErrorMessage.Exists;

                // Delete new Document Library
                DocumentLibrariesPage.DeleteDocumentLibrary();
            }
            //catch (Exception ex)
            //{
            //    var exception = ex;
            //}
            finally
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\TestData\\UploadToSharedDocumentsData.csv",
            "UploadToSharedDocumentsData#csv", DataAccessMethod.Sequential),
        DeploymentItem("FDACodedUITests_Framework\\TestData\\UploadToSharedDocumentsData.csv")]
        private void UploadToSharedDocuments()
        {
            try
            {
                //// Launch browser
                //Browser.LaunchAndNavigate(AppConfig.GetValue("URL"));

                //// Login
                //HomePage.Login(
                //    username: AppConfig.GetValue("Username"),
                //    password: AppConfig.GetValue("Password")
                //);



                // Navigate to "Shared Documents" library
                HomePage.ViewAllSiteContent();
                AllSiteContentPage.OpenSharedDocumentsLibrary();

                // Upload test documents (Word, Excel, and PDF documents)
                DocumentLibrariesPage.UploadDocument(
                    docName: Bind("FilePath")
                );

                // Verify document was uploaded successfully by passing the name of
                // the list item to search for
                DocumentLibrariesPage.AssertItemAddedToLibrary(
                    itemName: Bind("ExpectedFileName")
                );

                // Delete test document by specifying the name of the list item to 
                // target for deletion
                DocumentLibrariesPage.DeleteDocument(
                    itemName: Bind("ExpectedFileName")
                );

            }
            //catch (Exception ex)
            //{

            //}
            finally
            {

            }
        }
        #endregion
    }
}
