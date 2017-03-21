using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public abstract class GradeTracker
    {
        public abstract void AddGrade(double grade);
        public abstract void AddGrades(List<double> grades);
        public abstract GradeStatistics ComputeStats();
        public abstract void WriteGrades();
        public abstract IEnumerator GetEnumerator();
        public string Name
        {
            get { return this.Name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    this.Name = value;
                }
            }
        }
    }
}
