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

    public class _DataIFSP : BaseWebAiiTest
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
    
        [CodedStep(@"Get AfterTom date")]
        public void GetafterTomDate()
        {
            DateTime aftomor = DateTime.Today.AddDays(2);
            string datetom = aftomor.ToString(@"MM/dd/yyyy");
            Utility.newDate = datetom;
            SetExtractedValue("DateTom", datetom);
        }
    
        [CodedStep(@"GetPluYearMinusDay")]
        public void GetDatePlusYearMinusDay()
        {
            DateTime enteredDate = DateTime.Parse(Utility.newDate); 
            enteredDate = enteredDate.AddYears(1);
            enteredDate = enteredDate.AddDays(-1);
             string dateToCheck = enteredDate.ToString(@"MM/dd/yyyy");
            Utility.dateToCheck = dateToCheck;
            SetExtractedValue("PlusYMinD", dateToCheck);
        }
    
        [CodedStep(@"IFSP Plan Duration Correct")]
        public void IFSP_Plan_Duration_Correct()
        {
            Utility.IFSPData.Add("Plan Duration is correct");
        }
        
         [CodedStep(@"IFSP Plan Duration Non Correct")]
        public void IFSP_Plan_Duration_Non_Correct()
        {
            Utility.IFSPData.Add("Plan Duration is NOT correct");
            Utility.error_flag = true;
        }
    
        [CodedStep(@"New Coded Step")]
        public void _DataIFSP_CodedStep1()
        {
            
        }
    }
}
