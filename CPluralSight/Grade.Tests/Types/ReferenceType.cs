using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grade.Tests.Types
{
    [TestClass]
    public class ReferenceType
    {
        [TestMethod]
        public void VariableHoldReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

          
            g1.Name = "Rinkal's Grade Book";
            Assert.AreEqual("Rinkal's Grade Book",g2.Name);
            Assert.AreEqual(g1.Name, g2.Name);
        }

        [TestMethod]
        public void IntVariableHoldValue()
        {
            int x1 = 100;
            int x2 = x1;

           // x1 = 4;


            Assert.AreEqual(x1, x2);
        }
        [TestMethod]
        public void CompareString()
        {

            string str1 = "Rinkal";
            string str2 = "Rinkal";

            bool result = string.Equals(str1, str2);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ReferenceTypePassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookName(book2);
            Assert.AreEqual("GradeBook", book1.Name);   
        }
        private void GiveBookName(GradeBook book)
        {
            book.Name = "GradeBook";
        }

        [TestMethod]
        public void ValueTypePassByValue()
        {
            int x = 46;
            Incrementnumber(x);

            Assert.AreEqual(46, x);
        }
        private void Incrementnumber(int number)
        {
            number = number + 1;
        }

        [TestMethod]
        public void AddDayTime()
        {
            DateTime date = new DateTime(2018, 1, 1);
            date=date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void UpperCaseType()
        {
            string name = "scott";

            name=name.ToUpper();

            Assert.AreEqual("SCOTT",name);
        }

        [TestMethod]
        public void UsingArray()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
            grades[2] = 50.02f;
            grades[3] = 21.77f;
        }
    }
}
