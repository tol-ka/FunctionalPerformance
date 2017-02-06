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

    public class FillLock504Annual : BaseWebAiiTest
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
    
        [CodedStep(@"SetPlanto")]
        public void SetPlanto()
        {
            Utility.plan = @"504";
SetExtractedValue("CurrentPlan", Utility.plan);
            Utility.row = 2;
        }
    
        [CodedStep(@"Set event Name")]
        public void setEventName()
        {
            Utility.eventName = @"504 Annual Meeting";
            SetExtractedValue("CurrentEventName", Utility.eventName);
        }
    
        [CodedStep(@"Set event Group Name")]
        public void setEventGroupName()
        {
            Utility.eventGroupName = @"504 Annual Meeting";
            SetExtractedValue("CurrentEventGroupName", Utility.eventGroupName);
        }
    
        [CodedStep(@"Set event Type")]
        public void setEventType()
        {
            Utility.eventType = @"Annual";
            SetExtractedValue("CurrentEventGroupName", Utility.eventGroupName);
        }
        
         
    }
}
