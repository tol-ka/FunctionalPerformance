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

    public class MAIN_FillLockIEPInitial1 : BaseWebAiiTest
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
      [CodedStep(@"Set Plan to IEP")]
        public void SetPlantoIEP()
        {
         Utility.plan = @"IEP";
        }
        [CodedStep(@"CreateNewSheet")]
        public void CreateNewSheet()
        {
             var todayDate = DateTime.Now.ToString("MMDD"); 
string dataSourcePath = this.ExecutionContext.DeploymentDirectory + @"\Data\PerformanceTestDataIEP.xls";
            var buildnum = Utility.currentBuild;
var filename = todayDate+"_PerformanceTestData1007.xls";
String myPath = "C:\\MatrixTestReport\\"+filename;
            Utility.filepath = myPath;
var column = Utility.column;
var row = Utility.row;            
if (!System.IO.File.Exists(myPath))
{
    System.IO.File.Copy(dataSourcePath, myPath);
}

            
        todayDate = DateTime.Now.ToString("MMdd");
 var sheetName = buildnum+"_"+Utility.currentDomain+"_"+todayDate;           
Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Open(myPath);
workbook.Sheets.Copy(Before: workbook.Sheets[1]); 
Microsoft.Office.Interop.Excel._Worksheet xlWorksheet =  (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
xlWorksheet.Name = sheetName;
            
excelApp.Visible = true;
excelApp.ActiveWorkbook.Save();

workbook.Close(false, Type.Missing, Type.Missing);
excelApp.Workbooks.Close();
System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);

excelApp.Quit();
GC.Collect();
System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
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
            Utility.eventName = @"IEP Interim Meeting";
        }
        
         [CodedStep(@"Set event Group Name")]
        public void setEventGroupName()
        {
            Utility.eventGroupName = @"IEP Interim Meeting";
        }
         [CodedStep(@"Set event Type")]
        public void setEventType()
        {
            Utility.eventType = @"Interim";
        }
        
    }
}
