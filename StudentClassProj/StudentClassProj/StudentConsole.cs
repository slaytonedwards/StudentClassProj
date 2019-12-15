//Author: Slayton Edwards 
//Date: 7/21/2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentClassProj;

namespace StudentClassProj
{
    class StudentConsole
    {
        static void Main(string[] args) 
        {
            //Console will ask for name, student number, classification, and major
            Student firstStudentObject = new Student();
            firstStudentObject.studentFirst = AskForStudentName("first");
            firstStudentObject.studentLast = AskForStudentName("last");
            firstStudentObject.studentNum = AskForStudentNumber();
            firstStudentObject.studentYear = AskForYear(firstStudentObject.FullName());
            firstStudentObject.studentMajor = AskForMajor(firstStudentObject.FullName());
            //Person will say what their name, student number, classification, and major is
            Console.WriteLine();
            Console.WriteLine(firstStudentObject.FullName());
            Console.WriteLine(firstStudentObject.studentNum);
            Console.WriteLine(firstStudentObject.studentYear);
            Console.WriteLine(firstStudentObject.studentMajor);
            Console.WriteLine();
            Console.ReadLine();
        }

       public static string AskForStudentName(string studentName) {
            //Person will insert the answers here
            Console.WriteLine("What is your {0} name? ", studentName);
            return Console.ReadLine();
        } 
        public static int AskForStudentNumber()
        {
            Console.WriteLine("What is your student number?");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static string AskForYear(string FullName)
        {
            Console.WriteLine("{0} , what is your classification?", FullName);
            return Console.ReadLine();
        }
        public static string AskForMajor(string FullName)
        {
            Console.WriteLine("{0} , what is your major?", FullName);
            return Console.ReadLine();
           
        }


        
    }
}
