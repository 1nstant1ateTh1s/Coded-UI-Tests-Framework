using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting;
using FDACodedUITests_Framework.UIMaps.HomePageUIMapClasses;
using FDACodedUITests_Framework.UIMaps.MyFDAGovHomeUIMapClasses;
using FDACodedUITests_Framework.UIMaps.MyFDAGovMyContentPageUIMapClasses;
using FDACodedUITests_Framework.UIMaps.DocumentLibrariesPageUIMapClasses;
using FDACodedUITests_Framework.UIMaps.AllSiteContentPageUIMapClasses;

namespace FDACodedUITests_Framework
{
    public class FDASharePointUITest
    {
        // Private fields for the properties
        #region Private members
        //protected HomePageUIMap homePage = new HomePageUIMap();
        //protected MyFDAGovHomeUIMap myFDAGovHomePage = new MyFDAGovHomeUIMap();
        //protected MyFDAGovMyContentPageUIMap myFDAGovMyContentPage = new MyFDAGovMyContentPageUIMap();
        private HomePageUIMap homePage = null;
        private MyFDAGovHomeUIMap myFDAGovHomePage = null;
        private MyFDAGovMyContentPageUIMap myFDAGovMyContentPage = null;
        private DocumentLibrariesPageUIMap documentLibrariesPage = null;
        private AllSiteContentPageUIMap allSiteContentPage = null;
        #endregion

        // Properties that get each UI Map
        #region Public members
        //public HomePageUIMap HomePage {
        //    get { return homePage; }
        //}

        //public MyFDAGovHomeUIMap MyFDAGovHomePage {
        //    get { return myFDAGovHomePage; }
        //}

        //public MyFDAGovMyContentPageUIMap MyFDAGovMyContentPage {
        //    get { return myFDAGovMyContentPage; }
        //}

        public FDASharePointUITest()
        {
            homePage = new HomePageUIMap();
        }

        /// <summary>
        /// Gets the HomePage from the HomePageUIMap
        /// </summary>
        public HomePageUIMap HomePage 
        {
            get 
            {
                if (homePage == null)
                {
                    homePage = new HomePageUIMap();
                }

                return homePage;
            }
            //set { homePage = value; }
        }

        /// <summary>
        /// Gets the MyFDAGovHomePage from the MyFDAGovHomePageUIMap
        /// </summary>
        public MyFDAGovHomeUIMap MyFDAGovHomePage 
        {
            get
            {
                if (myFDAGovHomePage == null)
                {
                    myFDAGovHomePage = new MyFDAGovHomeUIMap();
                }

                return myFDAGovHomePage;
            }
        }

        /// <summary>
        /// Gets the MyFDAGovMyContentPage from the MyFDAGovMyContentPageUIMap
        /// </summary>
        public MyFDAGovMyContentPageUIMap MyFDAGovMyContentPage
        {
            get
            {
                if (myFDAGovMyContentPage == null)
                {
                    myFDAGovMyContentPage = new MyFDAGovMyContentPageUIMap();
                }

                return myFDAGovMyContentPage;
            }
        }

        public DocumentLibrariesPageUIMap DocumentLibrariesPage
        {
            get
            {
                if (documentLibrariesPage == null)
                {
                    // Instantiate a new page from the UI Map classes
                    documentLibrariesPage = new DocumentLibrariesPageUIMap();

                    // Since the Document Libraries Page and Home Page both use
                    // the same browser page as the top level window, get
                    // the top level window properties from the Home Page.
                    documentLibrariesPage.DocumentLibraryBrowser.CopyFrom(
                        HomePage.FDASharePointBrowser);
                }

                return documentLibrariesPage;
            }
        }

        public AllSiteContentPageUIMap AllSiteContentPage
        {
            get
            {
                if (allSiteContentPage == null)
                {
                    // Instantiate a new page from the UI Map classes
                    allSiteContentPage = new AllSiteContentPageUIMap();

                    // Since the All Site Content Page and Home Page both use
                    // the same browser page as the top level window, get
                    // the top level window properties from the Home Page.
                    allSiteContentPage.AllSiteContentBrowser.CopyFrom(
                        HomePage.FDASharePointBrowser);
                }

                return allSiteContentPage;
            }
        }
        #endregion
    }
}
