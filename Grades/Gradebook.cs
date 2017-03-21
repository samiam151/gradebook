using System;
using System.Collections.Generic;
using System.Linq;

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

        public void AddGrade(double grade)
        {
            grades.Add(grade);
            Console.WriteLine(String.Concat("Grade Entered: ", grades.Last()));
        }

        public void AddGrades(List<double> grades)
        {
            if (grades.Count > 0)
            {
                foreach (var grade in grades)
                {
                    this.AddGrade(grade);
                }
            }
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

        public virtual GradeStatistics ComputeStats()
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

        public override string ToString()
        {
            return "I am a gradebook!!!";
        }
    }
}
