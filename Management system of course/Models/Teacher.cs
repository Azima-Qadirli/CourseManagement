using System;
using Management_system_of_course.Models.BaseEntities;

namespace Management_system_of_course.Models
{
    public class Teacher : Entity
    {
        public int TeacherNumber { get; set; }

        public Teacher(string name, string surname, int teacherNumber) : base(name, surname)
        {
            TeacherNumber = teacherNumber;
        }

        public override string ToString()
        {
            return $"Teacher Number: {TeacherNumber}, Teacher Name: {Name}, Teacher Surname: {Surname}";
        }
    }
}