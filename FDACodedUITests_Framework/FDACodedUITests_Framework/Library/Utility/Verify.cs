using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace FDACodedUITests_Framework.Library
{
    public class Verify
    {
        /// <summary>
        /// Waits and checks the property value of a control
        /// </summary>
        /// <param name="control">The control to check</param>
        /// <param name="property">Name of the property to check</param>
        /// <param name="expectedValue">The expected value of the control property to check for</param>
        /// <param name="millisecondsTimeout">Time in milliseconds to wait for the control property value</param>
        public static void WaitForControlPropertyEqual(UITestControl control, string property, 
            string expectedValue, int millisecondsTimeout)
        {
            Assert.IsTrue(control.WaitForControlPropertyEqual(property, expectedValue, millisecondsTimeout),
                string.Format("Expected: {0} Actual: {1}", expectedValue, control.GetProperty(property)));
        }
    }
}
