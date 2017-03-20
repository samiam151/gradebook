using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class Gradebook
    {
        public Gradebook()
        {
            grades = new List<double>();
        }
        public Gradebook(string name)
        {
            grades = new List<double>();
            this.Name = name;   
        }
        public Gradebook(string name, double firstGrade)
        {
            grades = new List<double>();
            this.Name = name;
            this.AddGrade(firstGrade);
        }

        public string Name {
            get { return this.Name; }
            set {
                if (String.IsNullOrEmpty(value))
                {
                    this.Name = value;
                }
            }
        }

        public GradeStatistics ComputeStats()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        private List<double> grades { get; set; }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
            Console.WriteLine(String.Concat("Grade Entered: ", grades.Last()));
        }
        public static string toString()
        {
            return "I am a gradebook!!!";
        }
    }
}
