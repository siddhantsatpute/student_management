using CaseStudyOne;
using CaseStudyOne.Models;
using NodaTime;
using System;
using System.Collections;

namespace StudentManagement
{
    //Driver class
    class App
    {
        static Course course;

        //Main method
        static void Main(string[] args)
        {
            /* //Scenario 1
             scenarioOne();

             //Scenario 2
             scenarioTwo();

             //Scenario 3
             scenarioThree();
 */
            //Display welcome text
            Console.WriteLine("WELCOME TO ST. GEORGE COLLEGE OF MANAGEMENT STUDIES, LONDON, U.K.\n");

            //Question about course




            //Sceanrio 4
            getCourse();
        }

        static void getCourse()
        {
            Console.WriteLine("Which course you want to opt ? Choose option 1 or 2");
            Console.WriteLine("1. Degree Course - $30,000");
            Console.WriteLine("2. Diploma Course - $20,000");

            String opt = Console.ReadLine();
            int option = Convert.ToInt32(opt);

            switch (option)
            {
                case 1:
                    Console.WriteLine("Choose course Level :");
                    Console.WriteLine("A. Bachelors");
                    Console.WriteLine("B. Masters");

                    String op = Console.ReadLine();

                    Level level = Level.Bachelor;

                    if (op.ToLower().Equals("a"))
                    {
                        level = Level.Bachelor;
                    } 

                    else if(op.ToLower().Equals("b"))
                    {
                        level = Level.Masters;
                    }

                    else
                    {
                        Console.WriteLine("WRONG CHOICE. PLEASE FILL AGAIN...");
                        getCourse();
                    }

                    Console.WriteLine("Do you want to opt for placement ? Y/N");
                    String yesOrNo = Console.ReadLine();

                    bool isPlacement = false;

                    if (yesOrNo.ToLower().Equals("y"))
                    {
                        isPlacement = true;
                    }

                    else if(yesOrNo.ToLower().Equals("n"))
                    {
                        isPlacement = false;
                    }

                    else
                    {
                        Console.WriteLine("WRONG CHOICE. PLEASE FILL AGAIN...");
                        getCourse();
                        course = null;
                    }

                    course = new DegreeCourse(level, isPlacement);

                    break;

                case 2:
                    Console.WriteLine("Choose course Type :");
                    Console.WriteLine("A. Professional");
                    Console.WriteLine("B. Academic");

                    String choice = Console.ReadLine();

                    CaseStudyOne.Models.Type type = CaseStudyOne.Models.Type.Acedemic;

                    if (choice.ToLower().Equals("a"))
                    {
                        type = CaseStudyOne.Models.Type.Professional;
                    }

                    else if (choice.ToLower().Equals("b"))
                    {
                        type = CaseStudyOne.Models.Type.Acedemic;
                    }

                    else
                    {
                        Console.WriteLine("WRONG CHOICE. PLEASE FILL AGAIN...");
                        getCourse();
                        course = null;
                    }

                    course = new DiplomaCourse(type);

                    break;

                default:
                    Console.WriteLine("WRONG CHOICE. PLEASE FILL AGAIN...");
                    getCourse();
                    course = null;
                    break;
            }

            scenarioFour();
        }

        
        //Scenario Four Method
        static void scenarioFour()
        {

            //Input for student data count
            Console.WriteLine("How many student data you want to store ?");
            String input = Console.ReadLine();
            int count = Convert.ToInt32(input);

            //Creating object of arraylist
            ArrayList studentList = new ArrayList();
            ArrayList enrollmentList = new ArrayList();
            ArrayList courseList = new ArrayList();

            //Iterating to take inputs from user
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enetr the details of student : " + (i + 1) + "\n");


                //Input for Student ID
                Console.WriteLine("Student ID : \n");
                String stuId = Console.ReadLine();
                int id = Convert.ToInt32(input);

                //Input for Student Name
                Console.WriteLine("Student Name : \n");
                String stuName = Console.ReadLine();

                //Input for Student DOB
                DateTime dob = verifyDate();

                //Input for Student Phone numbers
                Console.WriteLine("How many phone numbers you want to enter ?");
                String phone = Console.ReadLine();
                int phoneCount = Convert.ToInt32(phone);

                String[] phoneNo = new string[phoneCount];

                for (int j = 0; j < phoneCount; j++)
                {
                    Console.WriteLine("Enter phone number " + (j + 1) + " :");
                    String phoneNos = Console.ReadLine();
                    phoneNo[j] = phoneNos;
                }

                //Setting student data into arraylist
                StudentDataModel student = new StudentDataModel(id, stuName, dob, phoneNo);
                Enroll enroll = new Enroll(student, course, LocalDate.FromDateTime(DateTime.Now));
                studentList.Add(student);
                enrollmentList.Add(enroll);

                Console.WriteLine();
            }

            //Iterating to display Student data using foreach loop
            Info display = new Info();

            foreach (Enroll studentData in enrollmentList)
            {
                //Info.displayInfo(studentData);
                display.displayEnrollement(studentData);
            }
        }

        //Method for handling date of birth user inputs
        static DateTime verifyDate()
        {
            //Taking and reading inputs from user
            Console.WriteLine("Student Date of birth Format(DD-MM-YYYY): \n");
            String stuDob = Console.ReadLine();

            //Checking proper format for DOB
            DateTime dob;
            if (DateTime.TryParse(stuDob, out dob))
            {
                dob = dob;
                //Do nothing
            }
            //If format is not correct show message and crecursive call
            else
            {
                Console.WriteLine("Date of Birth format is not correct. Expected format is DD-MM-YYYY");
                verifyDate();
            }

            //Return the correct DOB
            return dob;
        }
    }
}
