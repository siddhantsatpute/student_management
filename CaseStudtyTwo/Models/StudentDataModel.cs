using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyOne
{
    //Model class to store the student data
    public class StudentDataModel
    {
        //Id of the student
        int studentId;
        //Name of the student
        String studentName;

        //Date of Birth od the student
        DateTime studentDob;

        //Phone Numbers of the student
        String[] phoneNumber;

        //College name of the student as static (Cannot be changed, declared as public so that can be used anywhere in the solution)
        public static String studentCollegeName = "St. George College of Management Studies, London";

        //Setter and Getter for the Student ID
        public int StudentId { get => studentId; set => studentId = value; }

        //Setter and Getter for the Student Name
        public string StudentName { get => studentName; set => studentName = value; }

        //Setter and Getter for the Student Date of Birth
        public DateTime StudentDob { get => studentDob; set => studentDob = value; }

        //Setter and Getter for phone numbers
        public string[] PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        //Overloaded Constructor of StudentDataModel
        public StudentDataModel(int studentId, string studentName, DateTime studentDob, String[] phoneNumber)
        {
            this.StudentId = studentId;
            this.StudentName = studentName;
            this.StudentDob = studentDob;
            this.PhoneNumber = phoneNumber;
        }
    }
}
