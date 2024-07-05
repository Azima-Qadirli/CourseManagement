using System;
using System.Collections.Generic;
using System.Linq;
using Management_system_of_course.Management.Interfaces;
using Management_system_of_course.Models;

namespace Management_system_of_course.Management
{
    public class StudentManagement : IManagement<Student>
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public void Add(Student student)
        {
  

            if (Students.Any(s => s.StudentNumber == student.StudentNumber))
            {
                Console.WriteLine("This student already exists in the system.");
                return;
            }
            Student newStudent = new Student(student.Name, student.Surname, student.StudentNumber);
            Students.Add(newStudent);
            Console.WriteLine("Student added successfully.");
        }

        public void Modify(Student student)
        {
            Student updatedStudent = Students.FirstOrDefault(s => s.StudentNumber == student.StudentNumber);
            if (student == null)
            {
                Console.WriteLine("Student is not found in the system.");
                return;
            }
            updatedStudent.Name = student.Name;
            updatedStudent.Surname = student.Surname;
            Console.WriteLine("Student information modified successfully.");
        }

        public void Remove(int number)
        {

            Student student = Students.FirstOrDefault(s => s.StudentNumber == number);

            if (student == null)
            {
                Console.WriteLine("Student is not found in system.");
                return;
            }
            Students.Remove(student);
            Console.WriteLine("Student removed successfully.");
        }

        public void DisplayAll()
        {
            foreach (var student in Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
