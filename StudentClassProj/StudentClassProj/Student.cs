namespace StudentClassProj
{
    class Student
    {
        //integers and strings needed for project
        public string studentFirst = string.Empty;
        public string studentLast = string.Empty;
        public int studentNum = 0;
        public string studentYear = string.Empty;
        public string studentMajor = string.Empty;

        //Two classes for finding the student name, student number, student classification, and student degree
        public Student()
        {

        }
        //Defines the strings and integer
        public Student(string firstName, string lastName, int studentNumber, string studentClassification, string studentDegree)
        {
            studentFirst = firstName;
            studentLast = lastName;
            studentNumber = studentNum;
            studentClassification = studentYear;
            studentDegree = studentMajor;
        }
        //Inserts a space between students first and last name
        public string FullName()
        {
            return studentFirst + " " + studentLast;
        }
    }
}