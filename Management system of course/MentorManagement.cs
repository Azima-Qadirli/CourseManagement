using System;
using System.Collections.Generic;
using System.Linq;

namespace Management_system_of_course
{
    public class MentorManagement
    {
        public List<Mentor> Mentors { get; set; } = new List<Mentor>();

        public void AddMentor(int numberMentor, string name, string surname)
        {
            if (Mentors.Any(m => m.NumberMentor == numberMentor))
            {
                Console.WriteLine("This mentor already exists in the system.");
                return;
            }

            Mentor newMentor = new Mentor(numberMentor, name, surname);
            Mentors.Add(newMentor);
            Console.WriteLine("Mentor added successfully.");
        }

        public void ModifyMentor(int numberMentor, string newName, string newSurname)
        {
            Mentor mentor = Mentors.Find(m => m.NumberMentor == numberMentor);
            if (mentor == null)
            {
                Console.WriteLine("This mentor is not found in the system.");
                return;
            }

            mentor.Name = newName;
            mentor.Surname = newSurname;
            Console.WriteLine("Everything is modified successfully.");
        }

        public void RemoveMentor(int numberMentor)
        {
            Mentors.RemoveAll(m => m.NumberMentor == numberMentor);
        }

        public void DisplayAllMentors()
        {
            foreach (var mentor in Mentors)
            {
                Console.WriteLine(mentor);
            }
        }
    }
}