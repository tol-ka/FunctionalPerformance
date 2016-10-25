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

    public class Medication_Services : BaseWebAiiTest
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
        public void Medication_Services_CodedStep()
        {
Utility.comment = "Add Medication Service";
            Utility.saveflag = "nosaveButOther";            
        }
    
        [CodedStep(@"Add_day_to_date")]
        public void Add_day()
        {
            object myData = GetExtractedValue("StartDateText");
            string date = myData.ToString();
DateTime dt = Convert.ToDateTime(date);
            DateTime newDate = dt.AddDays(2);
            string endDate = newDate.ToString("MM/dd/yyyy");
            Console.Out.WriteLine("new date generated: " +endDate);
            SetExtractedValue("EndDateText", endDate);
            
        }
    }
}
