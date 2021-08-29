using CaseStudyOne.Models;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyOne
{
    class Enroll
    {
        private StudentDataModel student;
        private Course course;
        private LocalDate enrollmentDate;

        public Enroll(StudentDataModel student, Course course, LocalDate enrollmentDate)
        {
            this.Student = student;
            this.Course = course;
            this.EnrollmentDate = enrollmentDate;
        }

        public StudentDataModel Student { get => student; set => student = value; }
        public LocalDate EnrollmentDate { get => enrollmentDate; set => enrollmentDate = value; }
        internal Course Course { get => course; set => course = value; }
    }
}
