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

    public class ModifyFreqAndChek : BaseWebAiiTest
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
    
       [CodedStep(@"goToMatrixURL")]
        public  void GoToMatrixURL()
        {
            ActiveBrowser.NavigateTo(Utility.matrixURL);
        }
        
        [CodedStep(@"goToPresentURL")]
        public  void GoToPresentURL()
        {
            ActiveBrowser.NavigateTo(Utility.presentURL);
        }
        
         [CodedStep(@"goToServiceURL")]
        public  void GoToServiceURL()
        {
            ActiveBrowser.NavigateTo(Utility.serviceURL);
        }
    
        [CodedStep(@"ChooseVerification")]
        public void ChooseVerification()
        {
            String grade = Data["Often"].ToString();
            Utility.currentLevel = grade;
           Utility.expectedChecked.Clear();
            Utility.ischecked.Clear();
            
            if (Utility.dropbox == "Self-Administered with Supervision" && grade == "Daily") {
                Utility.expectedChecked.Add(Utility.expectedAll[8]);
                Utility.column = 10;
                
            }
            else if (Utility.dropbox == "Self-Administered with Supervision" && grade == "Weekly") {
                Utility.expectedChecked.Add(Utility.expectedAll[7]);
                Utility.column = 9;
            }
             else if (Utility.dropbox == "Self-Administered with Supervision" && grade == "Monthly") {
                Utility.expectedChecked.Add(Utility.expectedAll[6]);
               Utility.column = 8;
            }
             else if (Utility.dropbox == "In-School Nursing Services" && grade == "Daily") {
                Utility.expectedChecked.Add(Utility.expectedAll[2]);
                Utility.column = 4;
            }
            else if (Utility.dropbox == "In-School Nursing Services" && grade == "Weekly") {
                Utility.expectedChecked.Add(Utility.expectedAll[1]);
                Utility.column = 3;
            }
             else if (Utility.dropbox == "In-School Nursing Services" && grade == "Monthly") {
                Utility.expectedChecked.Add(Utility.expectedAll[0]);
                Utility.column = 2;
            }
             else if (Utility.dropbox == "Trained School Staff" && grade == "Daily") {
                Utility.expectedChecked.Add(Utility.expectedAll[5]);
               Utility.column = 7;
            }
            else if (Utility.dropbox == "Trained School Staff" && grade == "Weekly") {
                Utility.expectedChecked.Add(Utility.expectedAll[4]);
                Utility.column = 6;
            }
             else if (Utility.dropbox == "Trained School Staff" && grade == "Monthly") {
                Utility.expectedChecked.Add(Utility.expectedAll[3]);
                Utility.column = 5;
            }
             else if (Utility.dropbox == "Trained School Staff and/or Schoolwide Nurse" && grade == "Daily") {
                Utility.expectedChecked.Add(Utility.expectedAll[11]);
                Utility.column = 13;
            }
            else if (Utility.dropbox == "Trained School Staff and/or Schoolwide Nurse" && grade == "Weekly") {
                Utility.expectedChecked.Add(Utility.expectedAll[10]);
                Utility.column = 12;
            }
             else if (Utility.dropbox == "Trained School Staff and/or Schoolwide Nurse" && grade == "Monthly") {
                Utility.expectedChecked.Add(Utility.expectedAll[9]);
                Utility.column = 11;
            }
             this.ExecuteTest("DomainD/FullQuestion1Test/Verifications/VerifyRows.tstest");
        }
         
          [CodedStep(@"SetFlag")]
        public  void Set_Flag()
        {
          Utility.comment = "Save Service";
            Utility.saveflag = "nosaveButOther";
        
        }
        
         [CodedStep(@"Choose Method")]
        public  void Choose_Method()
        {
            var testname = String.Format("_Services{0}.tstest",Utility.plan);
            this.ExecuteTest("Methods//"+testname);
         
    
        }
        }
    
}
