using System;
using Management_system_of_course.Models.BaseEntities;

namespace Management_system_of_course.Models
{
    public class Mentor : Entity
    {
        public int NumberMentor { get; set; }

        public Mentor(int numberMentor, string name, string surname) : base(name, surname)
        {
            NumberMentor = numberMentor;
        }

        public override string ToString()
        {
            return $"Number Mentor: {NumberMentor}, Mentor Name: {Name}, Mentor Surname: {Surname}";
        }
    }
}
