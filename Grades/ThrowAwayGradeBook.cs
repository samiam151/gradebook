using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class ThrowAwayGradeBook: Gradebook
    {
        public override GradeStatistics ComputeStats()
        {
            float lowest = float.MaxValue;
            if (grades.Count > 1) {
                foreach (float grade in grades)
                {
                    lowest = Math.Min(grade, lowest);
                }
            }

            this.grades.Remove(lowest);
            return base.ComputeStats();
        }
    }
}
