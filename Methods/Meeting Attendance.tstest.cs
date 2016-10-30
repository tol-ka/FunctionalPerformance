using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace PerformanceTesting
{

    public class Meeting_Attendance : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"New Coded Step")]
        public void Meeting_Attendance_ChoosePlan()
        {
if (Utility.plan == "IEP") {
    this.ExecuteTest(@"Methods\\_Meeting Attendance IEP.tstest");
}    
else if (Utility.plan == "EP") {
    this.ExecuteTest(@"Methods\\_Meeting Attendance EP.tstest");
}   

else if (Utility.plan == "PSSP") {
    this.ExecuteTest(@"Methods\\_Meeting Attendance PSSP.tstest");
}   
else if (Utility.plan == "IFSP") {
    this.ExecuteTest(@"Methods\\_Meeting Attendance IFSP.tstest");
}   
        }
    }
}
