using System;
using System.Collections.Generic;
using System.Linq;
using Management_system_of_course.Management.Interfaces;
using Management_system_of_course.Models;

namespace Management_system_of_course.Management
{
    public class TeacherManagement : IManagement<Teacher>
    {
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();

        public void Add(Teacher teacher)
        {
            if (Teachers.Any(t => t.TeacherNumber == teacher.TeacherNumber))
            {
                Console.WriteLine("This teacher already exists in the system.");
                return;
            }
            Teacher newTeacher = new Teacher(teacher.Name, teacher.Surname, teacher.TeacherNumber);
            Teachers.Add(newTeacher);
            Console.WriteLine("Teacher added successfully.");
        }

        public void Modify(Teacher teacher)
        {
            Teacher updatedTeacher = Teachers.FirstOrDefault(t => t.TeacherNumber == teacher.TeacherNumber);
            if (teacher == null)
            {
                Console.WriteLine("This teacher is not found in the system.");
                return;
            }
            updatedTeacher.Name = teacher.Name;
            updatedTeacher.Surname = teacher.Surname;
            Console.WriteLine("Everything is modified successfully.");
        }

        public void Remove(int number)
        {
            Teacher teacher = Teachers.FirstOrDefault(t => t.TeacherNumber == number);

            if (teacher == null)
            {
                Console.WriteLine("This teacher is not found in the system.");
                return;
            }
            Teachers.Remove(teacher);
            Console.WriteLine("Teacher removed successfully.");
        }

        public void DisplayAll()
        {
            foreach (var teacher in Teachers)
            {
                Console.WriteLine(teacher);
            }
        }
    }
}
