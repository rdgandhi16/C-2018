using System;
namespace Grades
{
    public class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);

            book.NameChanged += new NameChangeDelegate(OnNameChanged);
            book.NameChanged += new NameChangeDelegate(OnNameChanged2);
            //book.NameChanged = null;

            book.Name = "Rinkal Grade Book...";
            book.Name = "Grade Book..";

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.AverageGrade);

            Console.WriteLine("o/p for Overload..");

            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);

            Console.WriteLine(book.Name);

            Console.ReadLine();
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + " : " + result);
        }
        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + " : " +result);
        }

        static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"Grade Book changing name from {existingName} to {newName}");
        }
        static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine("***");
        }
    }
}
