using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Gradebook book = CreateGradeBook();
            book.AddGrades(new List<double>() { 91, 90, 87.5 });
            
            foreach (int grade in book.getGrades())
            {
                WriteResult("Grade: ", grade);
            }

            GradeStatistics stats = book.ComputeStats();
            WriteResult("Average", stats.AverageGrade);
        }

        private static void WriteResult<T>(string description, T result)
        {
            Console.WriteLine($"{description}: {result}");
        }

        private static Gradebook CreateGradeBook() {
            return new ThrowAwayGradeBook();
        }
    }
}
