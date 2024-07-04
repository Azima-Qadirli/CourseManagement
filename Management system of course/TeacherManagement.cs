using System;
using System.Collections.Generic;
using System.Linq;

namespace Management_system_of_course
{
    public class TeacherManagement
    {
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();

        public void AddTeacher()
        {
            Console.WriteLine("Enter teacher number to add:");
            int teacherNumber = int.Parse(Console.ReadLine());

            if (Teachers.Any(t => t.TeacherNumber == teacherNumber))
            {
                Console.WriteLine("This teacher already exists in the system.");
                return;
            }

            Console.WriteLine("Enter name of teacher:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter surname of teacher:");
            string surname = Console.ReadLine();
            Teacher newTeacher = new Teacher(name, surname, teacherNumber);
            Teachers.Add(newTeacher);
            Console.WriteLine("Teacher added successfully.");
        }

        public void ModifyTeacher(int teacherNumber, string newName, string newSurname)
        {
            Teacher teacher = Teachers.FirstOrDefault(t => t.TeacherNumber == teacherNumber);
            if (teacher == null)
            {
                Console.WriteLine("This teacher is not found in the system.");
                return;
            }
            teacher.Name = newName;
            teacher.Surname = newSurname;
            Console.WriteLine("Everything is modified successfully.");
        }

        public void RemoveTeacher()
        {
            Console.WriteLine("Enter teacher number to remove:");
            int teacherNumber = int.Parse(Console.ReadLine());

            Teacher teacher = Teachers.FirstOrDefault(t => t.TeacherNumber == teacherNumber);

            if (teacher == null)
            {
                Console.WriteLine("This teacher is not found in the system.");
                return;
            }
            Teachers.Remove(teacher);
            Console.WriteLine("Teacher removed successfully.");
        }

        public void DisplayAllTeachers()
        {
            foreach (var teacher in Teachers)
            {
                Console.WriteLine(teacher);
            }
        }
    }
}
