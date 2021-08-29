using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyOne.Models
{
    abstract class Course
    {
        String id;
        String name;
        String duration;
        String fees;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Duration { get => duration; set => duration = value; }
        public string Fees { get => fees; set => fees = value; }

        public abstract double calculateMonthlyFee();
    }
}
