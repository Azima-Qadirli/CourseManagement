using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_system_of_course.Models.BaseEntities
{
    public abstract class Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        protected Entity(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

    }
}
