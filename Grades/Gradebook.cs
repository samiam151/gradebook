using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Grades
{
    public class Gradebook : GradeTracker, IGradeTracker
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

        public override void AddGrade(double grade)
        {
            grades.Add(grade);
            Console.WriteLine(String.Concat("Grade Entered: ", grades.Last()));
        }

        public override void AddGrades(List<double> grades)
        {
            if (grades.Count > 0)
            {
                foreach (var grade in grades)
                {
                    this.AddGrade(grade);
                }
            }
        }

        public override GradeStatistics ComputeStats()
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

        protected List<double> grades { get; set; }

        public List<double> getGrades()
        {
            return this.grades;
        }

        public override void WriteGrades()
        {
            foreach (int grade in this.getGrades())
            {
                Console.WriteLine($"Grade: {grade}");
            }
        }

        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
        }

        public override string ToString()
        {
            return "I am a gradebook!!!";
        }
    }
}
