using Management_system_of_course.Models.BaseEntities;
using System.Text.RegularExpressions;

namespace Management_system_of_course.Management.Interfaces
{
    public interface IManagement<T> where T : class
    {
        void Add(T entity);
        void Modify(T entity);
        void Remove(int number);
        void DisplayAll();
    }
}
