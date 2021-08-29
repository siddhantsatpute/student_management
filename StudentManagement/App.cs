using CaseStudyOne;
using System;
using System.Collections;

namespace StudentManagement
{
    //Driver class
    class App
    {
        //Main method
        static void Main(string[] args)
        {
            //Scenario 1
            scenarioOne();

            //Scenario 2
            scenarioTwo();

            //Scenario 3
            scenarioThree();

            //Sceanrio 4
            scenarioFour();
        }

        //scenario one method
        static void scenarioOne()
        {
            Console.WriteLine("SCENARIO 1\n");

            String[] phoneNumber = { "1234567890", "1234567891"};

            //Creating some objects of StudentDataModel
            StudentDataModel studentDataOne = new StudentDataModel(1, "James Smith", DateTime.Parse("12-09-1995"), phoneNumber);
            StudentDataModel studentDataTwo = new StudentDataModel(2, "Peter Parker", DateTime.Parse("21-05-1996"), phoneNumber);
            StudentDataModel studentDataThree = new StudentDataModel(3, "Dwane J.", DateTime.Parse("17-09-1995"), phoneNumber);

            //Creating object of Info to display the info of the student objects
            Info displayInfo = new Info();

            //Displaying info of the student object
            Info.displayInfo(studentDataOne);
            Info.displayInfo(studentDataTwo);
            Info.displayInfo(studentDataThree);
        }

        //Scenario Two Method
        static void scenarioTwo()
        {
            Console.WriteLine("SCENARIO 2\n");

            //Array of StudentDataModel
            StudentDataModel[] studentArr = new StudentDataModel[3];

            //Array of student phone numbers
            String[] phoneNumber = { "1234567890", "1234567891" };

            //Creating some objects of StudentDataModel
            StudentDataModel studentDataOne = new StudentDataModel(1, "James Smith", DateTime.Parse("12-09-1995"), phoneNumber);
            StudentDataModel studentDataTwo = new StudentDataModel(2, "Peter Parker", DateTime.Parse("21-05-1996"), phoneNumber);
            StudentDataModel studentDataThree = new StudentDataModel(3, "Dwane J.", DateTime.Parse("17-09-1995"), phoneNumber);

            //Storing array into StudentDataModel
            studentArr[0] = studentDataOne;
            studentArr[1] = studentDataTwo;
            studentArr[2] = studentDataThree;

            //Creating object of Info
            Info display = new Info();

            //Iterating over studentArr to diaplay the student data
            for(int i=0; i<studentArr.Length; i++)
            {
                Info.displayInfo(studentArr[i]);
            }

        }

        //Scenario Three Method
        static void scenarioThree()
        {
            Console.WriteLine("SCENARIO 3\n");

            Console.WriteLine("How many student data you want to store ?");

            //Taking input for student data count from user
            String input = Console.ReadLine();

            //Converting raw string into int
            int count = Convert.ToInt32(input);

            //Creating instance of StudentDataModel
            StudentDataModel[] stuArr = new StudentDataModel[count];

            //Iterating as per student data count
            for(int i=0; i<count; i++)
            {
                //Taking inputs from user
                Console.WriteLine("Enter the details of student : "+(i+1)+"\n");

                //Input for Student ID
                Console.WriteLine("Student ID : \n");
                String stuId = Console.ReadLine();
                int id = Convert.ToInt32(input);

                //Input for Student Name
                Console.WriteLine("Student Name : \n");
                String stuName = Console.ReadLine();

                //Input for Student DOB
                DateTime dob = verifyDate();

                //Input for Phone Numbers
                Console.WriteLine("How many phone numbers you want to enter ?");
                String phone = Console.ReadLine();
                int phoneCount = Convert.ToInt32(phone);

                String[] phoneNo = new string[phoneCount];

                for (int j = 0; j < phoneCount; j++)
                {
                    Console.WriteLine("Enter phone number "+(j+1)+" :");
                    String phoneNos = Console.ReadLine();
                    phoneNo[j] = phoneNos;
                }

                //Setting value into StudentDataModel array
                StudentDataModel student = new StudentDataModel(id, stuName, dob, phoneNo);
                stuArr[i] = student;

                Console.WriteLine();
            }

            //Display all the array data
            Info display = new Info();

            for(int i=0; i<stuArr.Length; i++)
            {
                Info.displayInfo(stuArr[i]);
            }
        }

        //Scenario Four Method
        static void scenarioFour()
        {

            Console.WriteLine("SCENARIO 4\n");

            //Input for student data count
            Console.WriteLine("How many student data you want to store ?");
            String input = Console.ReadLine();
            int count = Convert.ToInt32(input);

            //Creating object of arraylist
            ArrayList studentList = new ArrayList();

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
                studentList.Add(student);

                Console.WriteLine();
            }

            //Iterating to display Student data using foreach loop
            Info display = new Info();

            foreach (StudentDataModel studentData in studentList)
            {
                Info.displayInfo(studentData);
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
