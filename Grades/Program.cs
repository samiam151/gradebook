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
            Gradebook book = new Gradebook();
            book.AddGrade(91);
            book.AddGrade(85.3);
            book.AddGrade(95.3);

            GradeStatistics stats = book.ComputeStats();
            WriteResult("Average", stats.AverageGrade);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result}");
        }
        static void WriteResult(string description, int result)
        {
            Console.WriteLine("{0}: {1}", description, result);
        }
    }
}
