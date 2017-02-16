using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
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

    public class WriteToExcelPerformance : BaseWebAiiTest
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
    
             
        
        [CodedStep(@"WriteToExcelPerf")]
        public void WriteToExcelPerformance_CodedStep1()
        {
string dataSourcePath = this.ExecutionContext.DeploymentDirectory + @"\Data\PerformData.xls";
var todayDate = DateTime.Now.ToString("MMDD"); 
            var timeToConvert = DateTime.Now;             
var est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
var todayDatetime1 = TimeZoneInfo.ConvertTime(timeToConvert, est);
            var todayDatetime = todayDatetime1.ToString("yyyy-MM-dd hh:mm tt");
            var filename = todayDate+@"PerformData.xls";
            string myPath = @"C:\\MatrixTestReport\\"+filename;

if (!System.IO.File.Exists(myPath))
{
    System.IO.File.Copy(dataSourcePath, myPath);
}

Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Open(myPath);

System.Threading.Thread.Sleep(1000);
ActiveBrowser.RefreshDomTree();

Utility.row = Convert.ToInt32(Data["Row1"]);

            excelApp.Cells[Utility.row , 2] = Data["Student"].ToString();
            excelApp.Cells[Utility.row , 4] = todayDatetime;
            excelApp.Cells[Utility.row , 6] = Utility.currentBuild;
            excelApp.Cells[Utility.row , 7] = Utility.perfData[0];
            excelApp.Cells[Utility.row , 8] = Utility.perfData[1];
            excelApp.Cells[Utility.row , 9] = Utility.perfData[2];
            excelApp.Cells[Utility.row , 10] = Utility.perfData[3];
            excelApp.Cells[Utility.row , 11] = Utility.perfData[4];
            excelApp.Cells[Utility.row , 12] = Utility.perfData[5];
            excelApp.Cells[Utility.row , 13] = Utility.perfData[6];
            excelApp.Cells[Utility.row , 14] = Utility.perfData[7];
            excelApp.Cells[Utility.row , 15] = Utility.perfData[8];
            excelApp.Cells[Utility.row , 16] = Utility.perfData[9];
            excelApp.Cells[Utility.row , 17] = Utility.perfData[10];
            excelApp.Cells[Utility.row , 18] = Utility.perfData[11];
            excelApp.Cells[Utility.row , 19] = Utility.perfData[12];
            excelApp.Cells[Utility.row , 20] = Utility.perfData[13];
            excelApp.Cells[Utility.row , 21] = Utility.perfData[14];
            
           

 Utility.func_comment = "";
  Utility.error_flag = false;           
  Utility.saveflag = "normal";
Utility.perfData.Clear();
//Utility.row ++;
excelApp.Visible = true;
excelApp.ActiveWorkbook.Save();

workbook.Close(false, Type.Missing, Type.Missing);
excelApp.Workbooks.Close();
System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
workbook = null;

excelApp.Quit();

GC.Collect();
System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);       
excelApp = null;
GC.Collect();
        GC.WaitForPendingFinalizers();
        }
        
        
    }
    
}
