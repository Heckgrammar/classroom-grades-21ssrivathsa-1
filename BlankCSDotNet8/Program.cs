using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Xml.Serialization;

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
        static string[] addStudent()
        {
            string[] details = new string[3];
            Console.WriteLine("enter the student's name:");
            details[0] = Console.ReadLine();
            Console.WriteLine("enter the student's ID number:");
            details[1] = Console.ReadLine();
            Console.WriteLine("enter the student's form");
            details[2] = Console.ReadLine();
            return details;
        }

        static void Main(string[] args)
        {
            int MAX_STUDENTS = 20;
            studentDetails[] students = new studentDetails[MAX_STUDENTS];
            int studentCount = 0;

            string[] subjects = {"art", "biology", "chemistry", "computer science", "drama", "engslish", "geography", "history", "maths", "music", "physics", "DT"};
            int MAX_SUBJECTS = subjects.Length;

            string[,] grades = new string[MAX_STUDENTS, MAX_SUBJECTS];

            //menu
            int choice = 0;
            do
            {
                Console.WriteLine("select an option and enter its number");
                Console.WriteLine("1. Add a student ");
                Console.WriteLine("2. Enter grades for a student ");
                Console.WriteLine("3. View all student grades");
                Console.WriteLine("4. Quit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    if (studentCount < MAX_STUDENTS - 1)
                    {
                        string[] temp = addStudent();
                        int num = Convert.ToInt32(temp[1]);
                        studentDetails x = new studentDetails(temp[0], num, temp[2]);
                        students[studentCount] = x;
                    }

                    Console.WriteLine(students[0].name);
                    Console.WriteLine(students[0].IDnum);
                    Console.WriteLine(students[0].form);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("enter the name of the student");
                    string studentName = Console.ReadLine();
                    int i = -1;
                    int num = -1;
                    while (i < students.Length) 
                    {
                        i++;
                        if (students[i].name == studentName)
                        {
                            num = i;
                            i = students.Length;
                        }
                    }
                    if (num == -1)
                    {
                        Console.WriteLine("student not found - returning to menu");
                        choice = 0;
                    }
                    else
                    {
                        Console.WriteLine($"enter grade for each subject for {}");
                    }

                }

            } while (choice == 0);



        }
    }
}
