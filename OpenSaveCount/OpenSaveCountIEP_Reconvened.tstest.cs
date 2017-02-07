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

    public class OpenSaveCountIEP_Reconvened : BaseWebAiiTest
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
    
        [CodedStep(@"ChooseAction")]
        public void OpenSaveCount_ChooseAction()
        {
            if(Utility.saveflag == "normal"){
                this.ExecuteTest("verify\\SaveFormAndCount.tstest");
            }
            else if(Utility.saveflag == "nosaveButOther"){
                this.ExecuteTest("verify\\ActFormAndCount.tstest");
            }
             else if(Utility.saveflag == "nosaveNoOther"){
                this.ExecuteTest("verify\\WriteToExcel.tstest");
            }
             Utility.saveflag = "normal";
        }
    }
}