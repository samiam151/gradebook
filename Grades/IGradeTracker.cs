using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    internal interface IGradeTracker : IEnumerable
    {
        void AddGrade(double grade);
        GradeStatistics ComputeStats();
        void WriteGrades();
        
    }
}
