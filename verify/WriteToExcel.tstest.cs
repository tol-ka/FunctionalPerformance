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

    public class WriteToExcel2 : BaseWebAiiTest
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
    
           
        public void WriteToExcelAcc(){
        
var todayDate = DateTime.Now.ToString("MMDD"); 

String myPath = Utility.filepath;


var buildnum = Utility.currentBuild;
var row = Utility.row;
//var row = Data.IterationIndex + 2;
var column = 2; 

Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Open(myPath);
Microsoft.Office.Interop.Excel._Worksheet xlWorksheet =  (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
Microsoft.Office.Interop.Excel.Range xlRange = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row , column];



System.Threading.Thread.Sleep(1000);
ActiveBrowser.RefreshDomTree();
 
    xlWorksheet.Cells[row , column] = Utility.opentime;
            if (Utility.opentime > 12000) {
   xlRange.Interior.Color = Excel.XlRgbColor.rgbRed; }
        
            if (Utility.saveflag == "normal")
            {
                column = 3;
    xlRange = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row , column];
     xlWorksheet.Cells[row , column] = Utility.savetime;
            if (Utility.savetime > 15000) {
   xlRange.Interior.Color = Excel.XlRgbColor.rgbRed; }
column = 5;  
             xlRange = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row , column];
             xlWorksheet.Cells[row , column] = Utility.func_comment;
            xlRange.Font.Color = Excel.XlRgbColor.rgbGreen; 
            if (Utility.error_flag) {
   xlRange.Font.Color = Excel.XlRgbColor.rgbRed; }
            }
            else if (Utility.saveflag == "nosaveNoOther"){
                 column = 3;
                 xlRange = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row , column];
                
     xlWorksheet.Cells[row , column] = "N/a";
                column = 5;  
                 xlRange = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row , column];
             xlWorksheet.Cells[row , column] = Utility.func_comment;
                xlRange.Font.Color = Excel.XlRgbColor.rgbGreen;
             if (Utility.error_flag) {
   xlRange.Font.Color = Excel.XlRgbColor.rgbRed; }
                //Utility.row = Utility.row + 1;
             Utility.row = Data.IterationIndex + 2;
            }
             else if (Utility.saveflag == "nosaveButOther"){
                  column = 3;
    xlRange = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row , column];
     xlWorksheet.Cells[row , column] = Utility.savetime;
            if (Utility.savetime > 15000) {
   xlRange.Interior.Color = Excel.XlRgbColor.rgbRed; }
                 column = 4;
             xlRange = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row , column];
            string s = string.Format("Time counted for '{0}' action", Utility.comment);
     xlWorksheet.Cells[row , column] = s;
            column = 5;  
              xlRange = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row , column];
             xlWorksheet.Cells[row , column] = Utility.func_comment;
            xlRange.Font.Color = Excel.XlRgbColor.rgbGreen;
             if (Utility.error_flag) {
   xlRange.Font.Color = Excel.XlRgbColor.rgbRed; }
              
            }

 Utility.func_comment = "";
  Utility.error_flag = false;           
  Utility.saveflag = "normal";

excelApp.Visible = true;
excelApp.ActiveWorkbook.Save();

workbook.Close(false, Type.Missing, Type.Missing);
excelApp.Workbooks.Close();
System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);

excelApp.Quit();
GC.Collect();
System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);}
        
    
        
    
        [CodedStep(@"WriteToExcel")]
        public void WriteToExcel_CodedStep()
        {
            WriteToExcelAcc();
        }
    }
}
