using System.Web.Services;
using System.Data;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
/*******************************************************************************************************************/
        [WebMethod]
        public bool[] InsertStudents(Student[] list)
        {
            return DAL.InsertStudents(list);
        }//close InsertStudents
/*******************************************************************************************************************/
        [WebMethod]
        public bool InsertAssessment(Assessment a)
        {
            return DAL.InsertAssessment(a);
        }//close InsertAssessment
/*******************************************************************************************************************/
        [WebMethod]
        public int FindTotalMarks()
        {
            return DAL.FindTotalMarks();
        }//close FindTotalMarks
/*******************************************************************************************************************/
        [WebMethod]
        public int GetAssessmentNumber(string type)
        {
            return DAL.GetAssessmentNumber(type);
        }//close GetAssessmentNumber
/*******************************************************************************************************************/
        [WebMethod]
        public DataTable GetTable(string table, string col)
        {
            return DAL.GetTable(table, col);
        }//close GetTable
/*******************************************************************************************************************/
        [WebMethod]
        public int GetSingleColValue(string get, string type)
        {
            return DAL.GetSingleColValue(get, type);
        }//close GetSingleColValue
/*******************************************************************************************************************/
        [WebMethod]
        public bool InsertOrUpdateMarks(int std_id, int a_id, int marks, bool update)
        {
            return DAL.InsertOrUpdateMarks(std_id, a_id, marks, update);
        }//close InsertOrUpdateMarks
/*******************************************************************************************************************/
        [WebMethod]
        public DataTable PrintGradeSheet()
        {
            return DAL.PrintGradeSheet();
        }//close PrintGradeSheet
/*******************************************************************************************************************/
        [WebMethod]
        public bool AllAssessmentGraded()
        {
            return DAL.AllAssessmentGraded();
        }//close InsertAssessment
/*******************************************************************************************************************/
    }//close class
}//close namespace
