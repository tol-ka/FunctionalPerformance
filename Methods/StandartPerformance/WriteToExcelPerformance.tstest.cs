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
    
        [CodedStep(@"New Coded Step")]
        public void WriteToExcelPerformance_CodedStep()
        {
var todayDate = DateTime.Now.ToString("MMDD"); 

String myPath = Utility.filepath;


var buildnum = Utility.currentBuild;
//var row = Utility.row;
//var row = Data.IterationIndex + 2;
//var column = 2; 
var sheetName = Utility.plan+"_"+Utility.eventType+"_"+buildnum+"_"+Utility.currentDomain; 
Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Open(@"C:\\MatrixTestReport\\PerformData.xlsx");
Microsoft.Office.Interop.Excel._Worksheet xlWorksheet =  (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[0];
//Microsoft.Office.Interop.Excel.Range xlRange = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row , column];



System.Threading.Thread.Sleep(1000);
ActiveBrowser.RefreshDomTree();
 Utility.func_comment = string.Join("\t", Utility.perfData);
              Console.Out.WriteLine("______results are:  " + Utility.func_comment);
            Log.WriteLine("______results are:  " + Utility.func_comment);
    xlWorksheet.Cells[2 , 6] = Utility.perfData[0];
            xlWorksheet.Cells[2 , 7] = Utility.perfData[1];
            xlWorksheet.Cells[2 , 8] = Utility.perfData[2];
            xlWorksheet.Cells[2 , 9] = Utility.perfData[3];
            xlWorksheet.Cells[2 , 10] = Utility.perfData[4];
            xlWorksheet.Cells[2 , 11] = Utility.perfData[5];
            xlWorksheet.Cells[2 , 12] = Utility.perfData[6];
            xlWorksheet.Cells[2 , 13] = Utility.perfData[7];
            xlWorksheet.Cells[2 , 14] = Utility.perfData[8];
            xlWorksheet.Cells[2 , 15] = Utility.perfData[9];
            xlWorksheet.Cells[2 , 16] = Utility.perfData[10];
            xlWorksheet.Cells[2 , 17] = Utility.perfData[11];
           

 Utility.func_comment = "";
  Utility.error_flag = false;           
  Utility.saveflag = "normal";
Utility.perfData.Clear();


excelApp.Visible = true;
excelApp.ActiveWorkbook.Save();

workbook.Close(false, Type.Missing, Type.Missing);
excelApp.Workbooks.Close();
System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);

excelApp.Quit();
GC.Collect();
System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);}            
        
        [CodedStep(@"New Coded Step")]
        public void WriteToExcelPerformance_CodedStep1()
        {
string dataSourcePath = this.ExecutionContext.DeploymentDirectory + @"\Data\domainResults.xlsx";
string myPath = "C:\\domainResults.xlsx";

if (!System.IO.File.Exists(myPath))
{
    System.IO.File.Copy(dataSourcePath, myPath);
}

Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Open(myPath);

System.Threading.Thread.Sleep(1000);
ActiveBrowser.RefreshDomTree();

if (ActiveBrowser.ContainsText("already been registered"))
{
    excelApp.Cells[Data.IterationIndex + 2 , 1] = "Registered";
}
if (ActiveBrowser.ContainsText("is still available"))
{
    excelApp.Cells[Data.IterationIndex + 2 , 1] = "Available";
}

excelApp.Visible = true;
excelApp.ActiveWorkbook.Save();

workbook.Close(false, Type.Missing, Type.Missing);
excelApp.Workbooks.Close();
System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);

excelApp.Quit();
GC.Collect();
System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);            
        }
    }
    
}
