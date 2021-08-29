using CaseStudyOne.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyOne
{
    interface AppEngine
    {
        public void introduce(Course course);
        public void register(StudentDataModel student);
        public List<StudentDataModel> listOfStudents();
        public void enroll(StudentDataModel student, Course course);
        public List<Enroll> listOfEnrollments();
    }
}
