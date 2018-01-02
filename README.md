# Course Grading Service using ASMX, C# and SQL Server 
This project utilizes a SOAP based Web Service (ASMX) to access a Microsoft SQL Server database so as to store information
related to students and assessment in a course. This Web Service is consumed by a WinFrom application.

## Database
The database script is uploaded with the name 'script.sql'. The tables and columns of the course database are given below:

- **Student**:
  - **std_id:** Student ID
  - **fname:** First Name
  - **lname:** Last Name

- **Assessment**:
  - **a_id:** Assessment ID
  - **date:** Date
  - **type:** Assessment Type
  - **marks:** Maximum Marks

- **std_assessment**:
  - **std_id:** Student ID
  - **a_id:** Assessment ID
  - **marks:** Marks Obtained
  
Assessment can be of the following types:

- **Quiz** 
- **Assignment**
- **Mid term**
- **Final**
 
## Web Service
The Web Service can perform the following funtions:

- **Add Student**
  - Adds a single student to the course database 
- **Add Multiple Students**
  - Adds a list of students to the course database 
- **Add New Assessment**
  - Adds a new assessment to the course 
- **Add Marks of Assessment**
  - Adds marks to an already added assessment by providing a list of students and marks
- **Generate Grade**
  - After all the assessment’s total marks sum up to 100 marks and all assessments have been graded, generate grade can be selected to assign letter grades. 
- **Print Grade Sheet**
  - Print Grade Sheet is available every time, it displays the list of all students with marks obtained and total marks until now. Percentage is also displayed.

The code to access the Database is logically divided into DAL and DBHelper. DBHelper establishes connection to the database and defines the execution of various database operations supported by 'System.Data.SqlClient'. Data Access Layer (DAL) utilizes DBHelper to execute various SQL queries. Thus, DBHelper is kept general and DAL can be changed as per requirements. 

## WinForm Application
Each functionality of the Web Service is consumed in the Windows Form application. The GUI developed ensures the proper implementation of the functions provided by the service. The grading scheme is also defined here which is given below:

- Marks 86 or above = **A Grade**
- Marks 74 or above = **B Grade**
- Marks 62 or above = **C Grade**
- Marks 50 or above = **D Grade**

## Notes
1. The Web Service URL is: 'http://localhost:61245/WebService1.asmx'. 
2. The Solution contains 2 projects, one is the Web Service and second is the WinForm application. 
3. Database name is mentioned in the Web.config (connectionString tag) under the Web Service Project thus, database name can be changed without the need of building the project again.
4. The code is developed in Visual Studio 2015 with target framework 4.5.2.
