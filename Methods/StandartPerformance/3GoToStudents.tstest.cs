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

    public class GoToStudents : BaseWebAiiTest
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
    
        [CodedStep(@"GoToStu")]
        public void GoToStu()
        {
                                    String bbaseUrl = Settings.Current.Web.BaseUrl.ToString();
                          if ((bbaseUrl.Contains("dade.acceliqc.com")))
                {
                    Utility.currentDomain = "qc";
                    
                }
                else if (bbaseUrl.Contains("miami-demo.accelidemo.com"))
                {
                    Utility.currentDomain = "demo";
                    
                   
                }
                else if (bbaseUrl.Contains("dade-pilot.acceliplan.com"))
                {
                    Utility.currentDomain = "pilot";
                    
                   
                }
                
                 else if (bbaseUrl.Contains("dade-training.acceliplan.com"))
                {
                    Utility.currentDomain = "training";
                    
                   
                }
                  else if (bbaseUrl.Contains("dadematrix.acceliplan.com"))
                {
                    Utility.currentDomain = "dade_matrix";
                    
                   
                }
                
                else if (bbaseUrl.Contains("daderesearch.acceliplan.com"))
                {
                    Utility.currentDomain = "research";
                    
                   
                }
                
                 else if (bbaseUrl.Contains("dade.acceliplan.com"))
                {
                    Utility.currentDomain = "prod";
                    
                   
                }           
                            String address = ("/Plan/Students");
                            Console.Out.WriteLine(address); 
                            ActiveBrowser.NavigateTo(Settings.Current.Web.BaseUrl+address, true);
                        
        }
    }
}
