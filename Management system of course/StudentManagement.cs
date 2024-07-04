using System;
using System.Collections.Generic;
using System.Linq;

namespace Management_system_of_course
{
    public class StudentManagement
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public void AddStudent()
        {
            Console.WriteLine("Enter number of student to add: ");
            int studentNumber = int.Parse(Console.ReadLine());

            if (Students.Any(s => s.StudentNumber == studentNumber))
            {
                Console.WriteLine("This student already exists in the system.");
                return;
            }

            Console.WriteLine("Enter name of student:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter surname of student:");
            string surname = Console.ReadLine();
            Student newStudent = new Student(name, surname, studentNumber);
            Students.Add(newStudent);
            Console.WriteLine("Student added successfully.");
        }

        public void ModifyStudent(int studentNumber, string newName, string newSurname)
        {
            Student student = Students.FirstOrDefault(s => s.StudentNumber == studentNumber);
            if (student == null)
            {
                Console.WriteLine("Student is not found in the system.");
                return;
            }
            student.Name = newName;
            student.Surname = newSurname;
            Console.WriteLine("Student information modified successfully.");
        }

        public void RemoveStudent()
        {
            Console.WriteLine("Enter number of student to remove:");
            int studentNumber = int.Parse(Console.ReadLine());

            Student student = Students.FirstOrDefault(s => s.StudentNumber == studentNumber);

            if (student == null)
            {
                Console.WriteLine("Student is not found in system.");
                return;
            }
            Students.Remove(student);
            Console.WriteLine("Student removed successfully.");
        }

        public void DisplayAllStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
