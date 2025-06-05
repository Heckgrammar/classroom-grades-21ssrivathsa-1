using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BlankCSDotNet8
{
    internal class Program
    {
        struct studentDetails
        {
            public string name;
            public int IDnum;
            public string form;

            public studentDetails (string name1, int IDnum1, string form1)
            {
                name = name1;
                IDnum = IDnum1;
                form = form1;
            }
                
        }

        static void Main(string[] args)
        {
            int MAX_STUDENTS = 60;
            int[] students = new int[MAX_STUDENTS];
            int studentCount = 0;

            string[] subjects = {"maths", "english", "chemistry", "biology", "physics", "DT", "computer science", "music", "drama", "art", "geography", "history"};
            int MAX_SUBJECTS = subjects.Length;

            string[,] grades = new string[MAX_STUDENTS, MAX_SUBJECTS];

            //menu
            Console.WriteLine("select an option and enter its number");
            Console.WriteLine("1. Add a student ");
            Console.WriteLine("2. Enter grades for a student ");
            Console.WriteLine("3. View all student grades");
            Console.WriteLine("4. Quit");



        }
    }
}
