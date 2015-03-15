﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace FDACodedUITests_Framework.UIMaps.MyFDAGovHomeUIMapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class MyFDAGovHomeUIMap
    {
        
        /// <summary>
        /// Navigate to the my.FDA.gov "My Content" page
        /// </summary>
        public void NavToMyContentPage()
        {
            #region Variable Declarations
            HtmlHyperlink uIMyContentHyperlink = this.UIMyNewsfeedWindowsIntWindow.UIMyNewsfeedDocument.UIZz7_MySiteTopNavigatPane.UIMyContentHyperlink;
            #endregion

            // Click 'My Content' link
            Mouse.Click(uIMyContentHyperlink, new Point(41, 23));
        }
        
        #region Properties
        public UIMyNewsfeedWindowsIntWindow UIMyNewsfeedWindowsIntWindow
        {
            get
            {
                if ((this.mUIMyNewsfeedWindowsIntWindow == null))
                {
                    this.mUIMyNewsfeedWindowsIntWindow = new UIMyNewsfeedWindowsIntWindow();
                }
                return this.mUIMyNewsfeedWindowsIntWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIMyNewsfeedWindowsIntWindow mUIMyNewsfeedWindowsIntWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIMyNewsfeedWindowsIntWindow : BrowserWindow
    {
        
        public UIMyNewsfeedWindowsIntWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "My Newsfeed";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("My Newsfeed");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIMyNewsfeedDocument UIMyNewsfeedDocument
        {
            get
            {
                if ((this.mUIMyNewsfeedDocument == null))
                {
                    this.mUIMyNewsfeedDocument = new UIMyNewsfeedDocument(this);
                }
                return this.mUIMyNewsfeedDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIMyNewsfeedDocument mUIMyNewsfeedDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIMyNewsfeedDocument : HtmlDocument
    {
        
        public UIMyNewsfeedDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "My Newsfeed";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/default.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://my.preprod.fda.gov/default.aspx";
            this.WindowTitles.Add("My Newsfeed");
            #endregion
        }
        
        #region Properties
        public UIZz7_MySiteTopNavigatPane UIZz7_MySiteTopNavigatPane
        {
            get
            {
                if ((this.mUIZz7_MySiteTopNavigatPane == null))
                {
                    this.mUIZz7_MySiteTopNavigatPane = new UIZz7_MySiteTopNavigatPane(this);
                }
                return this.mUIZz7_MySiteTopNavigatPane;
            }
        }
        #endregion
        
        #region Fields
        private UIZz7_MySiteTopNavigatPane mUIZz7_MySiteTopNavigatPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIZz7_MySiteTopNavigatPane : HtmlDiv
    {
        
        public UIZz7_MySiteTopNavigatPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "zz7_MySiteTopNavigationMenu";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "My Newsfeed\r\nCurrently selectedMy Conten";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "s4-mysitetn";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=zz7_MySiteTopNavigationMenu class=s4-";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "17";
            this.WindowTitles.Add("My Newsfeed");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIMyContentHyperlink
        {
            get
            {
                if ((this.mUIMyContentHyperlink == null))
                {
                    this.mUIMyContentHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIMyContentHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIMyContentHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIMyContentHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIMyContentHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "My Content";
                    this.mUIMyContentHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/_layouts/MySite.aspx";
                    this.mUIMyContentHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIMyContentHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://my.preprod.fda.gov/_layouts/MySite.aspx";
                    this.mUIMyContentHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "static menu-item";
                    this.mUIMyContentHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "class=\"static menu-item\" href=\"/_layouts";
                    this.mUIMyContentHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "2";
                    this.mUIMyContentHyperlink.WindowTitles.Add("My Newsfeed");
                    #endregion
                }
                return this.mUIMyContentHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIMyContentHyperlink;
        #endregion
    }
}