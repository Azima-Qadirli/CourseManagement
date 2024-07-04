using System;
using System.Collections.Generic;
using System.Linq;

namespace Management_system_of_course
{
    public class Group
    {
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }
        public Mentor Mentor { get; set; }

        public Group(string groupCode, string groupName)
        {
            GroupCode = groupCode;
            GroupName = groupName;
            Students = new List<Student>();
        }

        public void AssignTeacher(Teacher teacher)
        {
            if (Teacher == null)
            {
                Teacher = teacher;
                Console.WriteLine($"Teacher {teacher.Name} {teacher.Surname} assigned to group {GroupCode} - {GroupName}.");
            }
            else
            {
                Console.WriteLine($"A teacher ({Teacher.Name} {Teacher.Surname}) is already assigned to this group.");
            }
        }

        public void AssignMentor(Mentor mentor)
        {
            if (Mentor == null)
            {
                Mentor = mentor;
                Console.WriteLine($"Mentor {mentor.Name} {mentor.Surname} assigned to group {GroupCode} - {GroupName}.");
            }
            else
            {
                Console.WriteLine($"A mentor ({Mentor.Name} {Mentor.Surname}) is already assigned to this group.");
            }
        }

        public void AssignStudent(Student student)
        {
            if (!Students.Any(s => s.StudentNumber == student.StudentNumber))
            {
                Students.Add(student);
                Console.WriteLine($"Student {student.Name} {student.Surname} assigned to group {GroupCode} - {GroupName}.");
            }
            else
            {
                Console.WriteLine($"A student ({student.Name} {student.Surname}) is already assigned to this group.");
            }
        }

        public override string ToString()
        {
            return $"Group Code: {GroupCode}, Group Name: {GroupName}";
        }
    }
}

