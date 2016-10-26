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

    public class CheckAccomodationLevel2 : BaseWebAiiTest
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
    //  public bool TextExists(){
     //       string textToFind = Data["AccommodationName"].ToString();
//bool found = false;
 //
//HtmlListItem cb = Pages.AccelifyIFSPInitial1.NameIdListboxUnorderedList; 
//foreach (HtmlListItem item in cb.Items)
//{
  //  if (item.Content.ToString().Equals(textToFind))
   // {
     //   found = true;
       // break;
   // }
  // 
//} return found;
  //    }
       [CodedStep(@"goToMatrixURL")]
        public  void GoToMatrixURL()
        {
            ActiveBrowser.NavigateTo(Utility.matrixURL);
        }
        
           [CodedStep(@"goToMatrixAURL")]
        public  void GoToMatrixAURL()
        {
            ActiveBrowser.NavigateTo(Utility.matrixAURL);
        }
        
         [CodedStep(@"goToMatrixCURL")]
        public  void GoToMatrixCURL()
        {
            ActiveBrowser.NavigateTo(Utility.matrixCURL);
        }
        
         [CodedStep(@"GetFilename")]
        public  void GetFilename()
        {
            Utility.filename = "Accomodations2109.xls";
        }
        
          [CodedStep(@"goToAccomURL")]
        public  void GoToAccomURL()
        {
            ActiveBrowser.NavigateTo(Utility.accomodURL);
        }
        
         [CodedStep(@"GetRow")]
        public  void Getrow()
        {
            Utility.row = Data.IterationIndex+2;
        }
       
        [CodedStep(@"SetTriggerToNonExist")]
         public void SetTriggerToNonExist()
        {
            Utility.trigger = "NonExist";
            Utility.column = 4;
        }
        
         [CodedStep(@"SetTriggerToEmpty")]
         public void SetTriggerToNonEmpty()
        {
            Utility.trigger = "Empty";
        }
   
    
        [CodedStep(@"SelectAccomodation")]
        public void SelectAccomodation()
        {
            // KendoListBox: select item by text ''
            Pages.AccelifyIFSPInitial1.NameIdListboxUnorderedList.SelectItem(((string)(System.Convert.ChangeType(Data["AccommodationName"], typeof(string)))));
          //  if(TextExists()) {Utility.trigger = "NonExist";
            //Log.WriteLine("Trigger now is "+Utility.trigger );}
        }
        
      
        }

}
