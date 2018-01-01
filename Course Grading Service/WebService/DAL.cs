using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebService
{
    public class DAL
    {
/*******************************************************************************************************************/
        public static bool[] InsertStudents(Student[] list)
        {
            //Init a result bool Array
            bool[] result = new bool[list.Count()];

            //Init DBHelper
            DBHelper dbh = new DBHelper();

            int i = 0;
            //Loop through and Insert each:
            foreach (Student s in list)
            {
                string query = @"INSERT INTO dbo.student VALUES ('" + s.fname + "','" + s.lname + "')";
                result[i] = dbh.ExecuteNonQuery(query);
                i++;
            }//close foreach

            //Return the results:
            return result;

        }//close InsertStudents
/*******************************************************************************************************************/
        public static bool InsertAssessment(Assessment a)
        {
            //Init DBHelper
            DBHelper dbh = new DBHelper();

            string query = @"INSERT INTO dbo.assessment VALUES (@date,'"+a.type+"',"+a.marks+")";
            return dbh.ExecuteNonQuery(query, a.date);

        }//close InsertAssessment
/*******************************************************************************************************************/
        public static bool InsertOrUpdateMarks(int std_id, int a_id, int marks, bool update)
        {
            //Init DBHelper
            DBHelper dbh = new DBHelper();
            string query = "";

            //Decide to Update/Insert 
            if (update == false)
                query = @"INSERT INTO dbo.std_assessment VALUES (" + std_id + "," + a_id + "," + marks + ")";
            else
                query = @"UPDATE dbo.std_assessment SET marks = "+marks+" where std_id = "+std_id+" AND a_id = "+a_id;

            return dbh.ExecuteNonQuery(query);

        }//close InsertOrUpdateMarks
/*******************************************************************************************************************/
        public static int FindTotalMarks()
        {
            DBHelper dbh = new DBHelper();
            string query = @"SELECT SUM(marks) from dbo.assessment";
            return dbh.ExecuteScalar(query);

        }//close FindTotalMarks
/*******************************************************************************************************************/
        public static int GetAssessmentNumber(string type)
        {
            DBHelper dbh = new DBHelper();
            string query = @"SELECT COUNT(a_id) from dbo.assessment WHERE type LIKE '"+type+"%'";
            return dbh.ExecuteScalar(query);

        }//close GetAssessmentNumber
/*******************************************************************************************************************/
        public static int GetSingleColValue(string get, string type)
        {
            DBHelper dbh = new DBHelper();
            string query = @"SELECT "+get+" from dbo.assessment WHERE type LIKE '" + type + "%'";
            return dbh.ExecuteScalar(query);

        }//close GetSingleColValue
/*******************************************************************************************************************/
        public static DataTable GetTable(string table, string col)
        {
            DBHelper dbh = new DBHelper();
            string query = "";

            //Select All/Or a Column
            if (col == null)
                query = @"SELECT * FROM " + table;

            else
                query = @"SELECT " + col + " FROM " + table;

            return dbh.GetDataTable(query);

        }//close GetTable
/****************************************************************************************************************************************************/
        public static DataTable PrintGradeSheet()
        {
            DBHelper dbh = new DBHelper();
            string query = @"SELECT s.std_id, s.fname, SUM(sa.marks) as 'Marks Obtained', SUM(a.marks) as 'Total Marks', (SUM(sa.marks)/SUM(a.marks) * 100) as 'Percentage (%)'" +
            " from dbo.student s, dbo.assessment a, dbo.std_assessment sa where s.std_id = sa.std_id AND a.a_id = sa.a_id GROUP BY s.std_id,s.fname";

            return dbh.GetDataTable(query);

        }//close PrintGradeSheet
/****************************************************************************************************************************************************/
        public static bool AllAssessmentGraded()
        {
            DBHelper dbh = new DBHelper();

            //Get the Count of Assessments
            string query = @"SELECT COUNT(a_id) from dbo.assessment";
            int aIds = dbh.ExecuteScalar(query);

            //Get All Gradeed Assessments
            query = @"SELECT COUNT(a.a_id) FROM dbo.assessment a, dbo.std_assessment sa WHERE a.a_id = sa.a_id";
            int assessmentGraded = dbh.ExecuteScalar(query);

            //Get All Students
            query = @"SELECT COUNT(std_id) FROM dbo.student";
            int stdIds = dbh.ExecuteScalar(query);

            //If No Assessments/Students Return false!
            if (aIds == 0 || stdIds == 0)
                return false;

            //If All Assessments are Assigned to All Students - Return True
            if (Convert.ToDouble(stdIds) == Convert.ToDouble(assessmentGraded)/aIds)
                return true;

            //Else Return False
            return false;
        }//close AllAssessmentGraded
/****************************************************************************************************************************************************/
    }//close class
}//close namespace