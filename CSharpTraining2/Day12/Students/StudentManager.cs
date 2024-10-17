using System;
using System.Collections.Generic;

namespace Students
{
    class StudentManager
    {
        private List<Students> stud = new List<Students>();
        public void AddStud(Students student)
        {
            if (GetStudent(student.RegisterNumber) != null)
            {
                Console.WriteLine("Student already exist");
                return;
            }
            stud.Add(student);
            Console.WriteLine("Student added successfully");
        }
        public void Search(string regNo)
        {
            var student = GetStudent(regNo);
            Console.WriteLine(student);
        }
        public void Update(string regNo,string name, int cls)
        {
            var student = GetStudent(regNo);
            if(student == null)
            {
                Console.WriteLine("Student not exist");
                return;
            }
            student.Name = name;
            student.Class = cls;
        }
        public void Delete(string regNo)
        {
            var student = GetStudent(regNo);
            if (student == null)
            {
                Console.WriteLine("Student not exist");
                return;
            }
            stud.Remove(student);
            Console.WriteLine("Deleted successfully: ");
        }
        private Students GetStudent(string regNo)
        {
            foreach (var student in stud)
            {
                if (student.RegisterNumber == regNo)
                {
                    return student;
                }
            }
            return null;
        }
    }      
}
 

