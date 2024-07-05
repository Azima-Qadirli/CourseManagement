using Management_system_of_course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_system_of_course.Management.Interfaces
{
    public interface IGroupManagement : IManagement<Models.Group>
    {
        void AddTeacher(string groupCode, Teacher teacher);
         void AddMentor(string groupCode, Mentor mentor);
         void AddStudent(string groupCode, Student student);
    }
}
