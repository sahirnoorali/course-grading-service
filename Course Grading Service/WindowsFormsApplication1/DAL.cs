using System;
using System.Collections.Generic;
using System.Data;

namespace WindowsFormsApplication1
{
    class DAL
    {
        WebServiceRef.WebService1 serviceObj;
/******************************************************************************************************************/
        public DAL()
        {
            serviceObj = new WebServiceRef.WebService1();

        }//close ctor
/******************************************************************************************************************/
        public bool[] InsertStudents(List<WebServiceRef.Student> list)
        {
            try
            {
                return serviceObj.InsertStudents(list.ToArray());
            }//close try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }//close catch

        }//close InsertStudents
/******************************************************************************************************************/
        public bool InsertAssessment(WebServiceRef.Assessment a)
        {
            try
            {
                return serviceObj.InsertAssessment(a);
            }//close try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }//close catch

        }//close InsertAssessment
/******************************************************************************************************************/
        public int FindTotalMarks()
        {
            try
            {
                return serviceObj.FindTotalMarks();
            }//close try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }//close catch

        }//close FindTotalMarks
/******************************************************************************************************************/
        public int GetAssessmentNumber(string type)
        {
            try
            {
                return serviceObj.GetAssessmentNumber(type);
            }//close try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }//close catch

        }//close GetAssessmentNumber
/******************************************************************************************************************/
         public DataTable GetTable(string table, string col = null)
          {
              try
              {
                if (col == null)
                    return serviceObj.GetTable(table, null);
                else
                    return serviceObj.GetTable(table, col);

              }//close try
              catch (Exception ex)
              {
                  Console.WriteLine(ex.Message);
                  return null;
              }//close catch

          }//close GetTable
/******************************************************************************************************************/
        public int GetSingleColValue(string get, string type)
        { 
            try
            {
                return serviceObj.GetSingleColValue(get,type);
            }//close try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }//close catch

        }//close GetSingleColValue
/******************************************************************************************************************/
        public bool InsertOrUpdateMarks(int std_id, int a_id, int marks, bool update)
        {
            try
            {
                return serviceObj.InsertOrUpdateMarks(std_id, a_id, marks, update);
            }//close try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }//close catch

        }//close InsertOrUpdateMarks
/******************************************************************************************************************/
        public DataTable PrintGradeSheet()
        {
            try
            {
                return serviceObj.PrintGradeSheet();
            }//close try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }//close catch

        }//close PrintGradeSheet
/******************************************************************************************************************/
        public bool AllAssessmentGraded()
        {
            try
            {
                return serviceObj.AllAssessmentGraded();
            }//close try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }//close catch

        }//close AllAssessmentGraded
/******************************************************************************************************************/
    }///close DAL
}//close namespace
