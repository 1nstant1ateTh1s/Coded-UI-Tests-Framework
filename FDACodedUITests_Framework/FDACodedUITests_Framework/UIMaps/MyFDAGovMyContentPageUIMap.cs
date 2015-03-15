namespace FDACodedUITests_Framework.UIMaps.MyFDAGovMyContentPageUIMapClasses
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
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

    public partial class MyFDAGovMyContentPageUIMap
    {
        public void UploadSharedDocument(string docName)
        {
            UploadSharedDocumentParams.UINameFileInputFileName = docName;
            UploadSharedDocument();
        }

        public void UploadPersonalDocument(string docName)
        {
            UploadPersonalDocumentParams.UINameFileInputFileName = docName;
            UploadPersonalDocument();
        }

        public void AssertDocAddedToSharedDocuments(string expected)
        {
            //AssertDocAddedToSharedDocumentsExpectedValues.UIOnetidDoclibViewTbl0TableRowCount
        }

        public void AssertDocAddedToPersonalDocuments(string expected)
        {

        }
    }
}
