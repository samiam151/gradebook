using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        public Gradebook init()
        {
            Gradebook testBook = new Gradebook("testBook");
            testBook.AddGrade(10);
            testBook.AddGrade(80);
            testBook.AddGrade(90);
            return testBook;
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2017, 1, 1);
            date = date.AddDays(1);
            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Scott";
            string name2 = "scott";
            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ComputeHighestGrade()
        {
            Gradebook testBook = this.init();
            GradeStatistics result = testBook.ComputeStats();
            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            Gradebook testBook = this.init();
            GradeStatistics result = testBook.ComputeStats();
            Assert.AreEqual(10, result.LowestGrade);
        }
    }
}
