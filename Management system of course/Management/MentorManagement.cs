using System;
using System.Collections.Generic;
using System.Linq;
using Management_system_of_course.Management.Interfaces;
using Management_system_of_course.Models;

namespace Management_system_of_course.Management
{
    public class MentorManagement : IManagement<Mentor>
    {
        public List<Mentor> Mentors { get; set; } = new List<Mentor>();

        public void Add(Mentor mentor)
        {
            if (Mentors.Any(m => m.NumberMentor == mentor.NumberMentor))
            {
                Console.WriteLine("This mentor already exists in the system.");
                return;
            }

            Mentor newMentor = new Mentor(mentor.NumberMentor, mentor.Name, mentor.Surname);
            Mentors.Add(newMentor);
            Console.WriteLine("Mentor added successfully.");
        }

        public void Modify(Mentor mentor)
        {
            Mentor updatedMentor = Mentors.Find(m => m.NumberMentor == mentor.NumberMentor);
            if (mentor == null)
            {
                Console.WriteLine("This mentor is not found in the system.");
                return;
            }

            updatedMentor.Name = mentor.Name;
            updatedMentor.Surname = mentor.Surname;
            Console.WriteLine("Everything is modified successfully.");
        }

        public void Remove(int number)
        {
            Mentors.RemoveAll(m => m.NumberMentor == number);
        }

        public void DisplayAll()
        {
            foreach (var mentor in Mentors)
            {
                Console.WriteLine(mentor);
            }
        }
    }
}