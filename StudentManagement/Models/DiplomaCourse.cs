using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyOne.Models
{
    enum Type { Professional, Acedemic}

    class DiplomaCourse : Course
    {
        Type type;

        public DiplomaCourse(Type type)
        {
            this.type = type;
        }

        public override double calculateMonthlyFee()
        {
            if(type == Type.Professional)
            {
                double percent = 10 / 100;
                double processingFee = 20000 * percent;
                return (20000 + processingFee);
            }
            else
            {
                double percent = 5 / 100;
                double processingFee = 20000 * percent;
                return (20000 + processingFee);
            }
        }
    }
}
