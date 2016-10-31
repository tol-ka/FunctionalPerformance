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

    public class FillLockIFSP_Annual : BaseWebAiiTest
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
    
        [CodedStep(@"SetPlantoIFSP")]
        public void SetPlantoIFSP()
        {
                     Utility.plan = @"IFSP";
        }
    
        [CodedStep(@"SaveCurrentBuild")]
        public void SaveCurrentBuild1()
        {
                                                object myData = GetExtractedValue("currentBuild");
                        var _build = myData.ToString();
                        //removing all but numbers in build
                       // String build = Regex.Replace(_build, @"\D+", String.Empty);
                        String build = new String(_build.Where(Char.IsDigit).ToArray());
                                                Utility.currentBuild = build;
        }
        
          [CodedStep(@"Set event Name")]
        public void setEventName()
        {
            Utility.eventName = @"IFSP Annual Meeting";
        }
    
          [CodedStep(@"Set event Type")]
        public void setEventType()
        {
            Utility.eventType = @"Annual";
        }
    
        [CodedStep(@"Set event Group Name")]
        public void setEventGroupName()
        {
                                    Utility.eventGroupName = @"IFSP Annual Meeting";
        }
        
    
    }
}
