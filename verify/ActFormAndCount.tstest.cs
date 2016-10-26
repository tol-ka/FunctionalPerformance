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

    public class ActFormAndCount : BaseWebAiiTest
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
        
      
         [CodedStep(@"Act Form And Count")]
        public void ActForm_Count()
        {
             var watch = System.Diagnostics.Stopwatch.StartNew();
 var testname = Data["formname"].ToString();    
            var filetestname = string.Format("Methods\\{0}_Action.tstest", testname);
            this.ExecuteTest(filetestname);
             Pages.AccelifyStudents0.Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>(new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=div", "TextContent=^Loading"), false, 0).Wait.ForExistsNot(30000);
watch.Stop();
Utility.savetime = watch.ElapsedMilliseconds;
            this.ExecuteTest("verify\\WriteToExcel.tstest");
            Utility.row = Utility.row + 1;
           // Utility.row = Data.IterationIndex + 2;
    }
    
       
    }
}
