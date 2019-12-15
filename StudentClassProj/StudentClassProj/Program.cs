using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassProj
{
    class StudentConsole
    {
        static void Main(string[] args) 
        {
            Student firstStudentObject = new Student();
            firstStudentObject.studentFirst = AskForStudentName("First");
            firstStudentObject.studentLast = AskForStudentName("Last");
            firstStudentObject.studentNum = AskForStudentNumber();
            firstStudentObject.studentMajor = AskForMajor(firstStudentObject.studentFirst);
        }
    }
}
