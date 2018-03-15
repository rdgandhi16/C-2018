using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grade.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(90,result.HighestGrade );
            
        }
        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(15);
            book.AddGrade(20);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(15, result.LowestGrade);
        }
    }
}
