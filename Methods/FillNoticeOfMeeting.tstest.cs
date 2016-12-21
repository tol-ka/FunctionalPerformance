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

    public class FillNoticeOfMeeting : BaseWebAiiTest
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
    
        [CodedStep(@"Set_formName")]
        public void setFormName()
        {
                        Utility.formname = "Notice of Meeting";
        }
    
        [CodedStep(@"Choose fields NOM")]
        public void ChooseFormToFill()
        {
            if (Utility.plan=="not defined")
            {Log.WriteLine("++__NOM test not run because no Utility.plan choosen_");}
            var noticetest = String.Format("Methods\\_NoticeOfMeeting{0}.tstest",Utility.plan);
                         this.ExecuteTest(noticetest);
        }
        
         [CodedStep(@"Get Today date")]
        public void GetCurrentDate()
        {
            
            string datetom = DateTime.Today.ToString(@"MM/dd/yyyy");
            string currentDay = DateTime.Today.ToString(@"dd");
            Utility.currentDate = datetom;
            Utility.currentDay = currentDay;
            SetExtractedValue("currentDate", datetom);
            SetExtractedValue("currentDay", currentDay);
        }
    }
}
