namespace FDACodedUITests_Framework.UIMaps.HomePageUIMapClasses
{
    using Microsoft.VisualStudio.TestTools.UITesting.SilverlightControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Input;
    using System.CodeDom.Compiler;
    using System.Text.RegularExpressions;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    public partial class HomePageUIMap
    {
        //public string CurrentUser
        //{
        //    get
        //    {
        //        return ((string)((this.mUICollaborationHomeWinWindow.UICollaborationHomeDocument)..GetProperty(HtmlHyperlink.PropertyNames.InnerText))).
        //    }
        //}

        /// <summary>
        /// Override Login method to accept parameterized values for UserName and Password.
        /// </summary>
        /// <param name="username">The username value</param>
        /// <param name="password">The (nonencrypted) password value</param>
        public void Login(string username, string password)
        {
            #region Variable Declarations
            HtmlHyperlink uIBrownAndrewHyperlink = this.FDASharePointBrowser.
                UICollaborationHomeDocument.UIBrownAndrewHyperlink;
            #endregion

            // Change the search criteria - Remove the logic we want to change
            uIBrownAndrewHyperlink.SearchProperties.Remove(HtmlHyperlink.PropertyNames.InnerText);

            LoginParams.UIUsernameEditText = username;
            LoginParams.UIPasswordEditSendKeys = Playback.EncryptText(password);
            Login();
        }

        /// <summary>
        /// Override CreateNewDocumentLibrary method to accept parameterized values
        /// for the Document Library name and the Document Library template type.
        /// </summary>
        /// <param name="name">The name of the Document Library</param>
        /// <param name="templateType">The document template type of the Document Library</param>
        public void CreateNewDocumentLibrary(string name, string templateType)
        {
            // Set the "Document Template Type" parameter and continue method
            CreateNewDocumentLibraryParams.DocumentTemplateOptionName = templateType;
            CreateNewDocumentLibrary(name);
        }

        /// <summary>
        /// Override CreateNewDocumentLibrary method to accept parameterized values for Name.
        /// </summary>
        /// <param name="name">The name value of the Document Library</param>
        public void CreateNewDocumentLibrary(string name)
        {
            // Set the "Name" parameter and continue method
            CreateNewDocumentLibraryParams.UINameEditText = name;
            CreateNewDocumentLibrary();
        }

        /// <summary>
        /// Add a new Document Library to SharePoint
        /// </summary>
        public void CreateNewDocumentLibrary()
        {
            #region Variable Declarations
            HtmlHyperlink uISiteActionsHyperlink = this.FDASharePointBrowser.UICollaborationHomeDocument.UISiteActionsHyperlink;
            HtmlHyperlink uINewDocumentLibraryCrHyperlink = this.FDASharePointBrowser.UICollaborationHomeDocument.UINewDocumentLibraryCrHyperlink;
            SilverlightEdit uINameEdit = this.FDASharePointBrowser.AddGalleryFrame.AddGalleryDocument.AddGallerySilverlightCustom.SilverlightPage.UIOptionsScollPane.UINameEdit;
            SilverlightButton uICreateButton = this.FDASharePointBrowser.AddGalleryFrame.AddGalleryDocument.AddGallerySilverlightCustom.SilverlightPage.UITopScrollViewerPane.UICreateButton;
            SilverlightComboBox documentTemplateComboBox = this.FDASharePointBrowser.AddGalleryFrame.AddGalleryDocument.AddGallerySilverlightCustom.SilverlightPage.UIOptionsScollPane.DocumentTemplateComboBox;
            SilverlightListItem documentTemplateListItem = this.FDASharePointBrowser.AddGalleryFrame.AddGalleryDocument.AddGallerySilverlightCustom.SilverlightPage.UIOptionsScollPane.DocumentTemplateComboBox.DocumentTemplateListItem;
            UITestControlCollection docTemplateTypes;
            SilverlightListItem selItem = null;
            string docTemplateName = this.CreateNewDocumentLibraryParams.DocumentTemplateOptionName;
            #endregion

            // Click 'Site Actions' link
            Mouse.Click(uISiteActionsHyperlink, new Point(40, 7));

            // Click 'New Document Library Create a place to store and s...' link
            Mouse.Click(uINewDocumentLibraryCrHyperlink, new Point(124, 23));

            // Wait for "Name" textbox to become visible and set text value
            uINameEdit.WaitForControlEnabled(8000);
            uINameEdit.Text = this.CreateNewDocumentLibraryParams.UINameEditText;

            // Choose "Document Template" type:
            // Click 'Document Template' combo box
            Mouse.Click(documentTemplateComboBox);

            docTemplateTypes = documentTemplateComboBox.Items;

            // Go through "document template" list options to determine which option should be selected
            foreach (SilverlightListItem item in docTemplateTypes)
            {
                var children = item.GetChildren();
                var childCount = children.Count;
                int i;
                string[] propValues = children.GetPropertyValuesOfControls<string>("Text");

                // Loop through child property values to determine if this List Item matches the requested document template name
                for (i = 0; i < childCount; i++)
                {
                    if (propValues[i].Equals(docTemplateName))
                    {
                        selItem = item; // grab the list item to select
                        break;
                    }
                }

                if (selItem != null) // if a new option is to be choosen ...
                {
                    // Set the "Document Template Type" list item option to be selected
                    documentTemplateListItem = selItem;
                    break;
                }
            }

            // Click 'Document Template List Item' list item
            Mouse.Click(documentTemplateListItem);

            // Click 'Create' button
            Mouse.Click(uICreateButton, new Point(37, 16));
        }

        public virtual CreateNewDocumentLibraryParams CreateNewDocumentLibraryParams
        {
            get
            {
                if ((this.mCreateNewDocumentLibraryParams == null))
                {
                    this.mCreateNewDocumentLibraryParams = new CreateNewDocumentLibraryParams();
                }
                return this.mCreateNewDocumentLibraryParams;
            }
        }

        private CreateNewDocumentLibraryParams mCreateNewDocumentLibraryParams;

        /// <summary>
        /// Verifies no errors were displayed
        /// </summary>
        public void AssertNoSilverlightErrorOnCreation()
        {
            #region Variable Declarations
            SilverlightText uIErrorMessage = this.FDASharePointBrowser.AddGalleryFrame.AddGalleryDocument.AddGallerySilverlightCustom.SilverlightPage.UITopScrollViewerPane.UIErrorMessage;
            string titleAlreadyExistsErrorMsg = this.AssertNoSilverlightErrorOnCreationExpectedValues.TitleAlreadyExistsErrorMessageText;
            string windowsVersionErrorMsg = this.AssertNoSilverlightErrorOnCreationExpectedValues.WindowsVersionErrorMessageText;
            #endregion

            //if (uIErrorMessage.Exists)
            //{
            //    string errMsg = uIErrorMessage.Text;
            //    if (errMsg.Contains(titleAlreadyExistsErrorMsg))
            //    {
            //        // Verify that the 'Text' property of Silverlight Error label contains 'A list, survey, discussion board, or document library with the specified title already exists in this Web site.  Please choose another title.'
            //        StringAssert.Contains(uIErrorMessage.Text, titleAlreadyExistsErrorMsg, "A list, survey, discussion board, or document library with the specified title al" +
            //                "ready exists in this Web site.");
            //    }
            //    else if (errMsg.Contains(windowsVersionErrorMsg))
            //    {
            //        // Verify that the 'Text' property of Silverlight Error label contains 'The specified program requires a newer version of Windows.'
            //        StringAssert.Contains(uIErrorMessage.Text, windowsVersionErrorMsg, "The specified program requires a newer version of Windows.");
            //    }

            //}

            // Verify that the 'Exists' property of 'Error' label is not equal to 'True' - If TRUE and no
            // previous "Asserts" failed, then this is an unknown error
            Assert.AreNotEqual(this.AssertNoSilverlightErrorOnCreationExpectedValues.UIErrorMessageExists, uIErrorMessage.Exists, uIErrorMessage.Text);
        }

        public virtual AssertNoSilverlightErrorOnCreationExpectedValues AssertNoSilverlightErrorOnCreationExpectedValues
        {
            get
            {
                if ((this.mAssertNoSilverlightErrorOnCreationExpectedValues == null))
                {
                    this.mAssertNoSilverlightErrorOnCreationExpectedValues = new AssertNoSilverlightErrorOnCreationExpectedValues();
                }
                return this.mAssertNoSilverlightErrorOnCreationExpectedValues;
            }
        }

        private AssertNoSilverlightErrorOnCreationExpectedValues mAssertNoSilverlightErrorOnCreationExpectedValues;
    }
    /// <summary>
    /// Parameters to be passed into 'CreateNewDocumentLibrary'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class CreateNewDocumentLibraryParams
    {
        #region Fields
        /// <summary>
        /// Wait for 3 seconds for user delay between actions; Type 'New Test Library' in 'Name' text box
        /// </summary>
        public string UINameEditText = "New Test Library";
        public string DocumentTemplateOptionName = "Microsoft Word document";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'AssertNoSilverlightErrorOnCreation'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class AssertNoSilverlightErrorOnCreationExpectedValues
    {

        #region Fields
        public string TitleAlreadyExistsErrorMessageText = "A list, survey, discussion board, or document library with the specified title al" +
            "ready exists in this Web site.  Please choose another title.";
        public string WindowsVersionErrorMessageText = "The specified program requires a newer version of Windows.";
        public bool UIErrorMessageExists = true;
        #endregion
}
}
