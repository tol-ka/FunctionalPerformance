using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;
using System.IO;
using Microsoft.Office.Interop;


namespace PerformanceTesting
{
    public static class Utility
    {
        public static String presentURL;
        public static String serviceURL;
        public static String matrixURL;
        public static String matrixCURL;
        public static String matrixAURL;
        public static String medServiceURL;
        public static String accomodURL;
        public static String datasource = "";
        public static int column = 1;
        public static int row = 2;
        public static long opentime = 000;
        public static long savetime = 000;
        //may be normal, nosaveNoOther, nosaveButOther
        public static String saveflag = "normal";
        public static String comment = "save";
        public static Boolean error_flag = false;
        public static String func_comment = "";
        //may be pssp, iep, ifsp, ep
        public static String plan = "not defined";
        public static String checkbox = "non defined";
        public static String currentDomain = "non defined";
        public static String checkbox2 = "non defined";
        public static String dropbox = "non defined";
        public static String expectedDropbox = "non defined";
        public static String currentLevel = "non defined";
        public static String expectedLevel = "non defined";
        public static String expectedRow = "non defined";
        public static String rowToCheck = "non defined";
        public static String currentRow = "non defined";
        public static String currentBuild = "non defined";
        public static String filepath = "non defined";
        public static String formname = "non defined";
        public static String trigger = "non defined";
        public static String filename = "non defined";
        public static ArrayList ischecked = new ArrayList();
        public static ArrayList expectedChecked = new ArrayList();
       public static ArrayList expectedAll = new ArrayList();
         
        public static void GetExAll(String text){
            
            expectedAll.Add(text);
        }
        
         public static void GetExAllClear(){
            
            expectedAll.Clear();
        }
        
          public static void GetExChecked(String text){
            
            expectedChecked.Add(text);
        }
        
           public static void CleanExpectChecked(){
            
            expectedChecked.Clear();
        }
          
          public static void CleanIsChecked(){
            
            ischecked.Clear();
        }
        public static void NoChecked(){
            
            ischecked.Add("None");
        }
        
        public static void AddChecked(String text){
            var num2 = Field2Num(text);
            ischecked.Remove("None");
            ischecked.Add(num2);
        }
        
        public static void writeToLog(String text){
            File.AppendAllText(
    filepath,
    text + Environment.NewLine);

        }
        
       public static String Num2Field (String num){
             /* local variable definition */
         //char grade = "B";
         String field = "non defined";
         switch (num)
         {
            case "1.1":
               field = "Requires no services or assistance beyond that which is normally available to all students";
               break;
            case "2.1":
                 field = "Monthly personal health care assistance";
                 break;
            case "2.2":
                 field = "Consultation on a monthly basis with student, teachers, family, agencies, or other providers";
                 break;
            case "2.3":
                 field = "Monthly monitoring of health status, procedures, or medication";
                 break;
            case "2.4":
                 field = "Specialized administration of medication";
                 break;
            case "2.5":
                 field = "Monthly assistance with agency referrals or coordination";
                 break;
             case "3.1":
                 field = "Weekly monitoring or assessment of health status, procedures, or medication";
                 break;
            case "3.2":
                 field = "Weekly counseling with student or family for related health care needs";
                 break;
            case "3.3":
                 field = "Weekly communication with family, physician, agencies, or other health-related personnel";
                 break;
            case "3.4":
                 field = "Invasive or specialized administration of medication";
                 break;
            case "3.5":
                 field = "Weekly collaboration with family, physicians, agencies, or others";
                 break;
            case "4.1":
                 field = "Daily assistance with or monitoring and assessment of health status, procedures, or medication";
                 break;
            case "4.2":
                 field = "Daily assistance with or monitoring of equipment related to health care needs";
                 break;
            case "4.3":
                 field = "Administration of non-oral medication";
                 break;
             case "4.4":
                 field = "Daily communication with family, physician, agencies, or other health-related personnel";
                 break;
            case "5.1":
                 field = "Daily assistance with procedures such as catheterization, suctioning, or tube feeding";
                 break;
            case "5.2":
                 field = "Continuous monitoring and assistance related to health care needs";
                 break;
               default:
            Console.WriteLine("Invalid Matrix number");
               break;
         }
         return field;
        }
        
        public static String Field2Num (String num){
            
         
         String field = "non defined";
         switch (num)
         {
            case "Requires no services or assistance beyond that which is normally available to all students":
               field = "1.1";
               break;
            case "Monthly personal health care assistance":
                 field = "2.1";
                 break;
            case "Consultation on a monthly basis with student, teachers, family, agencies, or other providers":
                 field = "2.2";
                 break;
            case "Monthly monitoring of health status, procedures, or medication":
                 field = "2.3";
                 break;
            case "Specialized administration of medication":
                 field = "2.4";
                 break;
            case "Monthly assistance with agency referrals or coordination":
                 field = "2.5";
                 break;
             case "Weekly monitoring or assessment of health status, procedures, or medication":
                 field = "3.1";
                 break;
            case "Weekly counseling with student or family for related health care needs":
                 field = "3.2";
                 break;
            case "Weekly communication with family, physician, agencies, or other health-related personnel":
                 field = "3.3";
                 break;
            case "Invasive or specialized administration of medication":
                 field = "3.4";
                 break;
            case "Weekly collaboration with family, physicians, agencies, or others":
                 field = "3.5";
                 break;
            case "Daily assistance with or monitoring and assessment of health status, procedures, or medication":
                 field = "4.1";
                 break;
            case "Daily assistance with or monitoring of equipment related to health care needs":
                 field = "4.2";
                 break;
             case "Administration of non-oral medication":
                 
                 field = "4.3";
        break;
             case "Daily communication with family, physician, agencies, or other health-related personnel":
                 field = "4.4";
                 break;
            case "Daily assistance with procedures such as catheterization, suctioning, or tube feeding":
                 field = "5.1";
                 break;
            case "Continuous monitoring and assistance related to health care needs":
                 field = "5.2";
                 break;
               default:
            Console.WriteLine("Invalid Matrix row");
               break;
         }
         return field;
        }
        
         public static String Field2NumA (String num){
            
         
         String field = "non defined";
         switch (num)
         {
            case "Requires no services or assistance beyond that which is normally available to all students":
               field = "1.1";
               break;
            case "Accommodations or supports to the general curriculum":
                 field = "2.1";
                 break;
            case "Curriculum compacting":
                 field = "2.2";
                 break;
            case "Differentiated instruction":
                 field = "2.3";
                 break;
            case "Electronic tools used independently":
                 field = "2.4";
                 break;
            case "Accessible instructional materials":
                 field = "2.5";
                 break;
                 case "Accommodations on assessment or accessible assessment materials":
                 field = "2.6";
                 break;
                 case "Assistance with note taking and studying":
                 field = "2.7";
                 break;
                 case "Referrals to agencies":
                 field = "2.8";
                 break;
                 case "Consultation on a monthly basis with teachers, family, agencies, or other providers":
                 field = "2.9";
                 break;
             case "Differentiated curriculum":
                 field = "3.1";
                 break;
            case "Electronic tools and assistive technology used with assistance":
                 field = "3.2";
                 break;
            case "Alternative textbooks, materials, assessments, assignments, or equipment":
                 field = "3.3";
                 break;
            case "Special assistance in general education class requiring weekly consultation":
                 field = "3.4";
                 break;
            case "Assistance for some learning activities in the general education setting":
                 field = "3.5";
                 break;
                 case "Direct, specialized instruction for some learning activities":
                 field = "3.6";
                 break;
                 case "Weekly collaboration with family, agencies, or other providers":
                 field = "3.7";
                 break;
            case "Extensive creation of special materials":
                 field = "4.1";
                 break;
            case "Direct, specialized instruction or curriculum for the majority of learning activities":
                 field = "4.2";
                 break;
             case "Instruction delivered within the community":              
                 field = "4.3";
                break;
             case "Assistance for the majority of learning activities":
                 field = "4.4";
                 break;
                  case "Assistive technology used with supervision for the majority of learning activities":
                 field = "4.5";
                 break;
            case "Daily assistance with procedures such as catheterization, suctioning, or tube feeding":
                 field = "5.1";
                 break;
          case "Continuous monitoring and assistance related to health care needs":
              field = "5.2";
                 break;
                 case "monitoring and assistance related to health care needs":
                 field = "5.3";
                 break;
                 case "and assistance related to health care needs":
                 field = "5.4";
                 break;
                 case "elated to health care needs":
                 field = "5.5";
                 break;
               default:
            Console.WriteLine("Invalid Matrix row");
               break;
         }
         return field;
        }
       
        
    }
}
