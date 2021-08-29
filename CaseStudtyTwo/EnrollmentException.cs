using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudtyTwo
{
    class EnrollmentException : Exception
    {
        //Use this static string to throw exception
        static string studentExistException = "Student Record already exist with us.";
        static string studentLimitFifty = "Student limit reached to 50. Cannot register further.";

        public EnrollmentException()
        {

        }

        //Constructor to handle and display the exception
        public EnrollmentException(string message) : base(message)
        {
            Console.WriteLine("ERROR OCCURRED :: "+message);
        }
    }
}
