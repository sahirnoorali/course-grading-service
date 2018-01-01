using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //List of Currently Added Students
        List<WebServiceRef.Student> studentList;

        //Count of those Students
        int count;

        //Disable All Controls If Grade Generated
        bool gradeGenerated = false;
/*******************************************************************************************************************/
        public Form1()
        {
            InitializeComponent();
            studentList = new List<WebServiceRef.Student>();
            InitControls();

        }//close ctor
/*******************************************************************************************************************/
        private void InitControls()
        {
            //Disable Input to the ComboBoxes
            aComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            numComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            aTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            //Initially Disable the Main Buttons
            AddMarksButton.Enabled = false;
            addStudentButton.Enabled = false;
            submitStudentButton.Enabled = false;
            submitAssessmentButton.Enabled = false;
            numComboBox.Enabled = false;

            //Get and Assign Marks Left:
            marksLeftLabel.Text = Convert.ToString(100 - FindTotalMarks());

            //Init Student GridView
            InitStudentGridView();

            //Refresh the DropDowns of Different Tabs
            RefreshAssessmentDropDown();
            RefreshStudentDropDown();

        }//close InitControls
/*******************************************************************************************************************/
        private int FindTotalMarks()
        {
            //Create a New DAL obj:
            DAL dalObj = new DAL();

            //Find Total Marks via WebService
            int marks = dalObj.FindTotalMarks();

            //No Rows in Assessment => 0 Total Marks
            if(marks == -1)
                return 0;
            //Otherwise Return Marks:
            return marks;

        }//close FindTotalMarks
/*******************************************************************************************************************/
        private void InitStudentGridView()
        {
            //Naming the DataGridView
            studentGridView.Name = "Student Grid View";

            //Setting up the Columns of DataGridView
            studentGridView.ColumnCount = 3;
            studentGridView.Columns[0].Name = "S.No:";
            studentGridView.Columns[1].Name = "First Name:";
            studentGridView.Columns[2].Name = "Last Name:";

            //AutoResize It
            AutoSizeGridView(studentGridView);

        }//close InitStudentGridView
/*******************************************************************************************************************/
        /*Fit the Columns To Occupy the Whole DataGridView Space:
          (Checks for Null) */
        private void AutoSizeGridView(DataGridView dgv)
        {
            if(dgv!= null)
                for (int i = 0; i < dgv.ColumnCount; i++)
                    dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }//close  AutoSizeGridView   
/*******************************************************************************************************************/
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            //Init Student Obj
            WebServiceRef.Student std = new WebServiceRef.Student();

            //Set it's Fields
            std.fname = fnameText.Text;
            std.lname = lnameText.Text;

            //Add in the List
            studentList.Add(std);

            //Show it in the Grid View           
            studentGridView.Rows.Add(++count, std.fname, std.lname);

            //Don't Enable Submit if Grade Generated
            if(gradeGenerated == false)
                submitStudentButton.Enabled = true;

            //Clear the Text Boxes
            fnameText.Clear();
            lnameText.Clear();

        }//close addStudentButton_Click
/*******************************************************************************************************************/
        private void lnameText_TextChanged(object sender, EventArgs e)
        {
            //Enable or Disable the Add Student Button Based on Conditions
            if (gradeGenerated == false)
                addStudentButton.Enabled = ((!string.IsNullOrWhiteSpace(fnameText.Text)) &&
                                            (!string.IsNullOrWhiteSpace(lnameText.Text)));


        }//close lnameText_TextChanged
/*******************************************************************************************************************/
        private void fnameText_TextChanged(object sender, EventArgs e)
        {
            //Enable or Disable the Add Student Button Based on Conditions
            if (gradeGenerated == false)
                addStudentButton.Enabled = ((!string.IsNullOrWhiteSpace(fnameText.Text)) &&
                                            (!string.IsNullOrWhiteSpace(lnameText.Text)));
        }//close fnameText_TextChanged
/*******************************************************************************************************************/
        private void submitStudentButton_Click(object sender, EventArgs e)
        {
            //Create a New DAL obj:
            DAL dalObj = new DAL();

            //Init a bool array:
            bool[] result = new bool[count - 1];

            //Insert the List of Students and Get Results:
            result = dalObj.InsertStudents(studentList);

            //Check the Results for Each Row Insert:
            if (result != null)
            {
                string temp = ""; bool error = false;
                for (int i = 0; i < (count - 1); i++)
                {
                    if (result[i] == false)
                    {
                        temp = temp + i + 1 + " ";
                        error = true;

                    }//close if
                }//close for

                //Display Error/Success
                if (error)
                    MessageBox.Show("Record(s) " + temp + "Couldn't Be Inserted.", "Result");
                else
                    MessageBox.Show("All Records Inserted", "Success");
     
            }//close if
            else
                MessageBox.Show("No Records Inserted", "Error");

            //Clear The List and GridView
            studentList.Clear();
            studentGridView.Rows.Clear();

            //Refresh Student Drop Down in Another Tab
            RefreshStudentDropDown();
        }//close submitButton_Click
/*******************************************************************************************************************/
        private void submitAssessmentButton_Click(object sender, EventArgs e)
        {
            //Display Error if Not Integer
            int parsedValue;
            if (!int.TryParse(marksTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Please Enter a Number in the Assessment Marks","Error");
                return;

            }//close if

            //Display Error if Out of Range
            if(Convert.ToInt32(marksLeftLabel.Text) - parsedValue < 0)
            {
                MessageBox.Show("Marks Can Not Exceed the Maximum Available Value", "Error");
                return;

            }//close if

            //Create a New DAL obj:
            DAL dalObj = new DAL();

            //Init Assessment Obj
            WebServiceRef.Assessment a = new WebServiceRef.Assessment();

            //Set its Fields
            a.marks = parsedValue;
            a.type = numComboBox.SelectedItem.ToString();
            a.date = DateTime.Today;

            //Insert Assessment via WebService
            bool result = dalObj.InsertAssessment(a);

            //Display Error/Success
            if(result == true)
                MessageBox.Show("Assessment Added "+a.date, "Success");
            else
                MessageBox.Show("Assessment Couldn't be Added", "Failure");

            //Update the Remaining Marks
            marksLeftLabel.Text = Convert.ToString(100 - FindTotalMarks());

            if (gradeGenerated == false)
                submitAssessmentButton.Enabled = !(Convert.ToInt32(marksLeftLabel.Text) == 0);

            //Reset the Controls
            aComboBox.SelectedIndex = aComboBox.Items.IndexOf("");
            numComboBox.Items.Clear();
            marksTextBox.Text = "";

            //Update/Refresh Assessment Dropdown
            RefreshAssessmentDropDown();

        }//close submitAssessmentButton_Click
/*******************************************************************************************************************/
        private void marksTextBox_TextChanged(object sender, EventArgs e)
        {
            //Enable or Disable the Submit Assessment Button Based on Conditions
            if (gradeGenerated == false)
            {
                submitAssessmentButton.Enabled = (!(string.IsNullOrEmpty(aComboBox.Text))) &&
                                             (!(string.IsNullOrEmpty(numComboBox.Text))) &&
                                             (!string.IsNullOrWhiteSpace(marksTextBox.Text));

                submitAssessmentButton.Enabled = !(Convert.ToInt32(marksLeftLabel.Text) == 0);
            }
        }//close marksTextBox_TextChanged    
/*******************************************************************************************************************/
        private void aComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enable or Disable the Submit Assessment Button Based on Conditions
            if (gradeGenerated == false)
            {
                numComboBox.Enabled = !(string.IsNullOrEmpty(aComboBox.Text));
                if (numComboBox.Enabled == true)
                    FillNumComboBox(aComboBox.SelectedItem.ToString());

                submitAssessmentButton.Enabled = ((!(string.IsNullOrEmpty(aComboBox.Text))) &&
                                                 (!(string.IsNullOrEmpty(numComboBox.Text))) &&
                                                 (!string.IsNullOrWhiteSpace(marksTextBox.Text)));

                submitAssessmentButton.Enabled = !(Convert.ToInt32(marksLeftLabel.Text) == 0);
            }
        }//close aComboBox_SelectedIndexChanged
/*******************************************************************************************************************/
        private void FillNumComboBox(string type)
        {
            //Clear the NumComboBox
            numComboBox.Items.Clear();

            //Create a New DAL obj:
            DAL dalObj = new DAL();

            //Get Number of Assessments via WebService
            int result = dalObj.GetAssessmentNumber(type);

            //Display +1 Available Assessment
            if (result == -1)
                numComboBox.Items.Add(type +" "+ Convert.ToString(result + 2));
            else
                numComboBox.Items.Add(type + " " + Convert.ToString(result + 1));

        }//close FillNumComboBox
/*******************************************************************************************************************/
        private void numComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enable or Disable the Submit Assessment Button Based on Conditions
            submitAssessmentButton.Enabled = ((!(string.IsNullOrEmpty(aComboBox.Text))) &&
                                                (!(string.IsNullOrEmpty(numComboBox.Text))) &&
                                                (!string.IsNullOrWhiteSpace(marksTextBox.Text)));
        }//close numComboBox_SelectedIndexChanged
/*******************************************************************************************************************/
        private void RefreshAssessmentDropDown()
        {
            //Clear the Assessment Type ComboBox
            aTypeComboBox.Items.Clear();

            //Create a New DAL obj:
            DAL dalObj = new DAL();

            //Get Assessment Type Column of Assessment via WebService
            DataTable dt = dalObj.GetTable("dbo.assessment","type");

            //Iterate if Not Null
            if (dt != null)
            {
                //Add the Column to the ComboBox 
                foreach (DataRow dr in dt.Rows)
                {
                    aTypeComboBox.Items.Add(dr[0].ToString());
                }//close foreach

            }//close if
        }//close RefreshAssessmentDropDown
/*******************************************************************************************************************/
        private void RefreshStudentDropDown()
        {
            //Clear the Student ComboBox
            stdComboBox.Items.Clear();

            //Create a New DAL obj:
            DAL dalObj = new DAL();

            //Get Name and ID Columns of Student via WebService
            DataTable dt = dalObj.GetTable("dbo.student", "fname, std_id");

            //Iterate if Not Null
            if (dt != null)
            {
                //Add the Columns to the ComboBox 
                foreach (DataRow dr in dt.Rows)
                {
                    stdComboBox.Items.Add(dr[0].ToString() + "-" + dr[1].ToString());
                }//close foreach

            }//close if
        }//close RefreshStudentDropDown
/*******************************************************************************************************************/
        private void aTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Create a New DAL obj:
            DAL dalObj = new DAL();

            //Get Marks of Assessment Type via WebService
            int marks = dalObj.GetSingleColValue("marks", aTypeComboBox.Text.ToString());

            //Display it
            marksLabel.Text = Convert.ToString(marks);

            //Enable or Disable the Add Marks Button Based on Conditions
            if (gradeGenerated == false)
                AddMarksButton.Enabled = ((!(string.IsNullOrEmpty(stdComboBox.Text))) &&
                                        (!(string.IsNullOrEmpty(aTypeComboBox.Text))) &&
                                        (!string.IsNullOrWhiteSpace(marksObtTextBox.Text)));

        }//close aTypeComboBox_SelectedIndexChanged
/*******************************************************************************************************************/
        private void marksObtTextBox_TextChanged(object sender, EventArgs e)
        {
            //Enable or Disable the Add Marks Button Based on Conditions
            if (gradeGenerated == false)
                AddMarksButton.Enabled = ((!(string.IsNullOrEmpty(stdComboBox.Text))) &&
                                        (!(string.IsNullOrEmpty(aTypeComboBox.Text))) &&
                                        (!string.IsNullOrWhiteSpace(marksObtTextBox.Text)));

        }//close marksObtTextBox_TextChanged
/*******************************************************************************************************************/
        private void stdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enable or Disable the Add Marks Button Based on Conditions
            if (gradeGenerated == false)
                AddMarksButton.Enabled = ((!(string.IsNullOrEmpty(stdComboBox.Text))) &&
                                        (!(string.IsNullOrEmpty(aTypeComboBox.Text))) &&
                                        (!string.IsNullOrWhiteSpace(marksObtTextBox.Text)));
        }//close stdComboBox_SelectedIndexChanged
/*******************************************************************************************************************/
        private void AddMarksButton_Click_1(object sender, EventArgs e)
        {
            //Display Error if Not Integer
            int marksObt;
            if (!int.TryParse(marksObtTextBox.Text, out marksObt))
            {
                MessageBox.Show("Please Enter a Number/Integer in the Marks Obtained", "Error");
                return;
            }//close if

            //Display Error if Out of Range
            if (marksObt > Convert.ToInt32(marksLabel.Text))
            {
                MessageBox.Show("Marks Can Not Exceed The Total Value", "Error");
                return;
            }//close if

            //Create a New DAL obj:
            DAL dalObj = new DAL();

            //Split the ComboBox Value with -
            string[] split = stdComboBox.Text.ToString().Split('-');

            //Get the Assessment ID of Assessment Type via WebService
            int a_id = dalObj.GetSingleColValue("a_id", aTypeComboBox.Text.ToString());
            
            //Insert Marks of a Student for an Assessment
            bool result = dalObj.InsertOrUpdateMarks(Convert.ToInt32(split[1]), a_id, Convert.ToInt32(marksObtTextBox.Text),false);

            //Display Success/Failure
            if (result == true)
                MessageBox.Show("Marks Added ", "Success");
            else
            {
               //Failure Means Value Exists Thus, Update the Marks
                bool res2 = dalObj.InsertOrUpdateMarks(Convert.ToInt32(split[1]), a_id, Convert.ToInt32(marksObtTextBox.Text),true);

                //Display Success/Failure
                if(res2 == true)
                    MessageBox.Show("Marks Updated (Was Added Before)", "Success");
                else
                    MessageBox.Show("Marks Couldn't Be Added or Updated", "Failure");

            }//close else

            //Reset the Controls
            stdComboBox.SelectedIndex = stdComboBox.Items.IndexOf("");
            aTypeComboBox.SelectedIndex = aTypeComboBox.Items.IndexOf("");
            marksLabel.Text = "";
            marksObtTextBox.Text = "";

        }//close AddMarksButton_Click_1
/*******************************************************************************************************************/
        private void printGradeButton_Click(object sender, EventArgs e)
        {
            //Create a New DAL obj:
            DAL dalObj = new DAL();

            //Get the GradeSheet Table via WebService
            DataTable dt = dalObj.PrintGradeSheet();

            //Assign it to GridView
            gradeSheetGridView.DataSource = dt;

            //Auto Resize the GridView
            AutoSizeGridView(gradeSheetGridView);

        }//close printGradeButton_Click
/*******************************************************************************************************************/
        private void generateGradeButton_Click(object sender, EventArgs e)
        {
            //Get Total Marks
            int total = FindTotalMarks();

            //Display Error if All Marks Aren't Assigned
            if (100 - total > 0) {
                MessageBox.Show("Only "+total+" Marks have been Assigned to Assessment out of 100 \n"+
                    "Grade Can't be Generated", "Error");
                return;
            }//close if

            //Create a New DAL obj:
            DAL dalObj = new DAL();

            //Get All Graded Assessments:
            bool result = dalObj.AllAssessmentGraded();

            //Display Failure
            if (result == false)
            {
                MessageBox.Show("Some Assessments Aren't Graded to Students.\n"+
                                "You Can Try Printing the Grade Sheet For Insight"+
                                "\n Grades Can't be Generated", "Failure");
                return;
            }//close if

            //On Success - Get Grade Sheet
            DataTable dt = dalObj.PrintGradeSheet();
            
            //Display Failure
            if (dt == null)
            {
                MessageBox.Show("An Exception Occured, Check Console for Details.\n Grades Can't be Generated", "Failure");
                return;
            }//close if

            //Init Grade GridView
            gradeGridView.ColumnCount = 3;
            gradeGridView.Columns[0].Name = "std_id";
            gradeGridView.Columns[1].Name = "Name";
            gradeGridView.Columns[2].Name = "Grade";

            gradeGridView.Columns[0].ValueType = typeof(Int32);
            gradeGridView.Columns[1].ValueType = typeof(string);
            gradeGridView.Columns[2].ValueType = typeof(string);

            //Fill the GridView with Data
            foreach (DataRow dr in dt.Rows)
            {
                double p = Convert.ToDouble(dr["Percentage (%)"].ToString());

                string grade;

                //Set the Grading Scheme:
                if (p >= 86)
                    grade = "A";

                else if (p >= 74)
                    grade = "B";

                else if (p >= 62)
                    grade = "C";

                else if (p >= 50)
                    grade = "D";

                else
                    grade = "F";

                //Add the Row to the GridView
                gradeGridView.Rows.Add(Convert.ToInt32(dr["std_id"].ToString()), dr["fname"].ToString(), grade);

            }//close foreach
            
            //Auto Resize Grid View
            AutoSizeGridView(gradeGridView);

            //Disable All Buttons As Grades Have Been Submitted:
            submitStudentButton.Enabled = false;
            addStudentButton.Enabled = false;
            submitAssessmentButton.Enabled = false;
            AddMarksButton.Enabled = false;
            generateGradeButton.Enabled = false;
            printGradeButton.Enabled = false;

            //Disable All Buttons as Grade is Generated
            gradeGenerated = true;

        }//close generateGradeButton_Click
/*******************************************************************************************************************/
    }//close Form
}//close namespace
