using CaseStudyOne.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyOne
{
    //Helper class to display the info of the student
    class Info
    {
        //Method to display the details of the student driven by object of StudentDataModel
        public static void displayInfo(StudentDataModel dataModel)
        {
            //Dispaly the ID of the of the student
            Console.WriteLine("Student ID - "+dataModel.StudentId);

            //Dispaly the Name of the Student
            Console.WriteLine("Student Name - "+dataModel.StudentName);

            //Dispaly the Date of birth of the student
            Console.WriteLine("Student DOB - "+dataModel.StudentDob);

            //Loop to display the Phone Number
            for(int i=0; i<dataModel.PhoneNumber.Length; i++)
            {
                Console.WriteLine("Student Phone Number "+(i+1)+" - "+dataModel.PhoneNumber[i]);
            }

            //Dispaly the college name of the student
            Console.WriteLine("Student College - " + StudentDataModel.studentCollegeName);

            //To dispaly space between two objects of StudentDataModel
            Console.WriteLine();
        }

        public void displayCourseData(Course course)
        {
            //Display Student ID
            Console.WriteLine("Student ID : "+course.Id);

            //Dispaly Student Name
            Console.WriteLine("Student Name : " + course.Name);

            //Dispaly Student Course duration
            Console.WriteLine("Student Course Duration : " + course.Duration);

            //Dispaly Fees
            Console.WriteLine("Student Fees : " + course.Fees);
        }
    }
}
