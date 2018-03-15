using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Grades
{
    public class GradeBook
    {

        public GradeBook()
        {
           _name = "Empty";
            grades = new List<float>();
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (_name!=value)
                    {
                        NameChanged(_name, value);
                    }
                    _name = value;
                }
            }
        }

        public NameChangeDelegate NameChanged;

        private string _name;

        private List<float> grades;

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0;

            foreach (var grade in grades)
            {
                sum += grade;
                stats.AverageGrade = sum / grades.Count;
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
               
            }

            
            return stats;
        }

    }
}
