using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

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

    public class UnivTest : BaseWebAiiTest
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
    
         [CodedStep(@"Set Event Name")]
        public void SeteventName()
        {
        string area2 = Utility.eventName;
            Log.WriteLine("Event to go: "+area2);
            Console.Out.WriteLine("__Event to go: "+area2);
        SetExtractedValue("EventName", area2);            
        }
        
        
        [CodedStep(@"Start Checking Forms")]
        public void startForms()
        {
                        var testname = String.Format("OpenSaveCount\\OpenSaveCount{0}_{1}.tstest",Utility.plan,Utility.eventType);
                         this.ExecuteTest(testname);
        }
    
        [CodedStep(@"set sheet Index")]
        public void UnivTest_setIndex()
        {
            if(Utility.plan == @"EP" && Utility.eventType == @"Initial"){
                Utility.sheetIndex = 1;
            }
             else if(Utility.plan == @"EP" && Utility.eventType == @"Eligibility"){
                Utility.sheetIndex = 2;
            }
            else if(Utility.plan == @"IEP" && Utility.eventType == @"Initial"){
                Utility.sheetIndex = 1;
            }
            else if(Utility.plan == @"IEP" && Utility.eventType == @"Annual"){
                Utility.sheetIndex = 2;
            }
             else if(Utility.plan == @"IEP" && Utility.eventType == @"Interim"){
                Utility.sheetIndex = 3;
            }
             
              else if(Utility.plan == @"IEP" && Utility.eventType == @"Reconvened"){
                Utility.sheetIndex = 4;
            }
             else if(Utility.plan == @"504" && Utility.eventType == @"Initial"){
                Utility.sheetIndex = 1;
            }
            else if(Utility.plan == @"504" && Utility.eventType == @"Annual"){
                Utility.sheetIndex = 2;
            }
             else if(Utility.plan == @"IFSP" && Utility.eventType == @"Initial"){
                Utility.sheetIndex = 1;
            }
            else if(Utility.plan == @"IFSP" && Utility.eventType == @"Annual"){
                Utility.sheetIndex = 2;
            }
             else if(Utility.plan == @"IFSP" && Utility.eventType == @"Interim"){
                Utility.sheetIndex = 3;
            }
             else if(Utility.plan == @"PSSP" && Utility.eventType == @"Initial"){
                Utility.sheetIndex = 1;
            }
            else if(Utility.plan == @"PSSP" && Utility.eventType == @"Annual"){
                Utility.sheetIndex = 2;
            }
             else {
                Utility.sheetIndex = 1;
            }
        }
    
        [CodedStep(@"Close Excel")]
        public void UnivTest_CloseExcelProc()
        {
            var excelprocesses = Process.GetProcesses().
                                 Where(pr => pr.ProcessName == "excel.exe");

foreach (var process in excelprocesses)
{
     process.Kill();
}
           
        }
    }
}
