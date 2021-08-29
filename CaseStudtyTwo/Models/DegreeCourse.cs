using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyOne.Models
{

    enum Level { Bachelor, Masters}

    class DegreeCourse : Course
    {
        Level courseLevel;
        bool isPlacementAvailable;

        public DegreeCourse(Level courseLevel, bool isPlacementAvailable)
        {
            this.courseLevel = courseLevel;
            this.isPlacementAvailable = isPlacementAvailable;
        }

        public override double calculateMonthlyFee()
        {
            if (isPlacementAvailable)
            {
                double percent = 10 / 100;
                double placementFee = 30000 * percent;
                return (30000 + placementFee);
            }
            else
            {
                return 30000;
            }
        }
    }
}
