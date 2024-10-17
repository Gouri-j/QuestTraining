using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studManager = new StudentManager();

            while (true)
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Search");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var stud = GetStudentData();
                        studManager.AddStud(stud);
                        break;
                    case "2":
                        Console.WriteLine("Enter Registration number");
                        var regNum = Console.ReadLine();
                        studManager.Search(regNum);
                        break;
                    case "3":
                        var studentToUpdate = GetStudentData();
                        studManager.Update(studentToUpdate.Name, studentToUpdate.RegisterNumber, studentToUpdate.Class);
                        break;
                    case "4":
                        Console.WriteLine("enter register number");
                        var regNumToDelete = Console.ReadLine();
                        studManager.Delete(regNumToDelete);
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
           
        }

        private static Students GetStudentData()
        {
            Students stud = new Students();
            Console.WriteLine("Enter name of student:");
            stud.Name = Console.ReadLine();

            Console.WriteLine("Enter student's registration id");
            stud.RegisterNumber = Console.ReadLine();

            Console.WriteLine("Enter class");
            stud.Class = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Enter the subject name:");
            string sub = Console.ReadLine();

            Console.WriteLine("Enter obtained mark");
            int obMark = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Maximum mark");
            int maxMark = int.Parse(Console.ReadLine());

            stud.Marks.Add(new Mark { Subject = sub, MarkObtained = obMark, MaximumMark = maxMark });

            return stud;
          
        }
    }
}
