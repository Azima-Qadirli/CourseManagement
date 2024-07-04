using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_system_of_course
{
    public  class Student:Entity
    {
        public int StudentNumber { get; set; }
        public Group Group { get; set; }
        public Student(string name,string surname,int studentNumber):base(name,surname)
        {
            StudentNumber = studentNumber;
            
        }
        public override string ToString()
        {
            return $"Student number: {StudentNumber} Student Name: {Name}  Student Surname: {Surname}";
        }
    }
}
