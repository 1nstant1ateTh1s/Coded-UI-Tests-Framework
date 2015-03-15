namespace FDACodedUITests_Framework.UIMaps.DocumentLibrariesPageUIMapClasses
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Input;
    using System.CodeDom.Compiler;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    
    public partial class DocumentLibrariesPageUIMap
    {
        public void UploadDocument(string docName)
        {
            UploadDocumentParams.NameFileInputFileName = docName;
            UploadDocument();
        }

        public void AssertItemAddedToLibrary(string itemName)
        {
            // Variable declarations
            HtmlRow itemRow = this.DocumentLibraryBrowser.DocumentLibraryPage
                .DocumentLibraryListViewTable.ItemRow;

            // Change the search criteria - remove the logic we want to change
            itemRow.FilterProperties.Remove(HtmlRow.PropertyNames.InnerText);
            itemRow.FilterProperties.Remove(HtmlRow.PropertyNames.Title);

            // Add it back in with the changes
            itemRow.FilterProperties[HtmlRow.PropertyNames.InnerText] = itemName;
            itemRow.FilterProperties[HtmlRow.PropertyNames.Title] = itemName;

            AssertItemAddedToLibrary();
        }

        /// <summary>
        /// Override DeleteDocument() method to accept the name of the list item to target
        /// for deletion.
        /// </summary>
        /// <param name="itemName">The name of the list item to delete.</param>
        public void DeleteDocument(string itemName)
        {
            // Variable declarations
            HtmlDiv itemRow = this.DocumentLibraryBrowser.DocumentLibraryPage
                .DocumentLibraryListViewTable.ListItemPane;
            
            // Change the search criteria if necessary
            if (itemRow.FilterProperties[HtmlDiv.PropertyNames.Title] != itemName)
            {
                // Remove the logic we want to change
                itemRow.FilterProperties.Remove(HtmlDiv.PropertyNames.InnerText);
                itemRow.FilterProperties.Remove(HtmlDiv.PropertyNames.Title);

                // Add it back in with changes
                itemRow.FilterProperties[HtmlDiv.PropertyNames.InnerText] = itemName;
                itemRow.FilterProperties[HtmlDiv.PropertyNames.Title] = itemName;
            }

            DeleteDocument();
        }

        /// <summary>
        /// Remove a Document Library from SharePoint
        /// </summary>
        public void DeleteDocumentLibrary()
        {
            #region Variable Declarations
            HtmlHyperlink librarySettingsHyperlink = this.DocumentLibraryBrowser.DocumentLibraryPage.LibrarySettingsHyperlink;
            HtmlHyperlink deleteThisDocumentLibraryHyperlink = this.DocumentLibraryBrowser.DocumentLibrarySettingsPage.DeleteThisDocumentLibraryHyperlink;
            BrowserWindow documentLibraryBrowser = this.DocumentLibraryBrowser;
            #endregion

            //Playback.PlaybackError += new EventHandler<PlaybackErrorEventArgs>(Playback_PlaybackError);

            // Wait for "Library Settings" button to become visible
            //librarySettingsHyperlink.WaitForControlEnabled(10000);

            // Click 'Library Settings' link
            Mouse.Click(librarySettingsHyperlink, new Point(22, 40));

            // Click 'Delete this document library' link
            Mouse.Click(deleteThisDocumentLibraryHyperlink, new Point(98, 10));

            // Click 'Ok' button in the browser dialog window
            documentLibraryBrowser.PerformDialogAction(BrowserDialogAction.Ok);

            //Playback.PlaybackError -= Playback_PlaybackError;
        }

        //void Playback_PlaybackError(object sender, PlaybackErrorEventArgs e)
        //{
        //    //throw new NotImplementedException();

        //    string errMsg = e.Error.Message;
            
        //    var obj = sender;

        //}
    }
}
