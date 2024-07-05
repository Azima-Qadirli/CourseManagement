using System;
using System.Collections.Generic;
using Management_system_of_course.Management.Interfaces;
using Management_system_of_course.Models;

namespace Management_system_of_course.Management
{
    public class GroupManagement : IGroupManagement
    {
        public List<Group> Groups { get; set; } = new List<Group>();

        public void Add(string groupCode, string groupName)
        {
            try
            {
                if (Groups.Exists(g => g.GroupCode == groupCode))
                {
                    throw new Exception("This group already exists in the system.");
                }
                else
                {
                    Group newGroup = new Group(groupCode, groupName);
                    Groups.Add(newGroup);
                    Console.WriteLine("Your group has been added to the system.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ModifyGroup(string groupCode, string newGroupName)
        {
            Group groupToUpdate = Groups.Find(g => g.GroupCode == groupCode);
            if (groupToUpdate == null)
            {
                Console.WriteLine("Group not found.");
                return;
            }

            groupToUpdate.GroupName = newGroupName;
            Console.WriteLine("Group modified successfully.");
        }

        public void DeleteGroup(string groupCode)
        {
            Groups.RemoveAll(g => g.GroupCode == groupCode);
        }

        public void DisplayAllGroups()
        {
            foreach (var group in Groups)
            {
                Console.WriteLine(group);
            }
        }

        public void AddTeacher(string groupCode, Teacher teacher)
        {
            Group groupToUpdate = Groups.Find(g => g.GroupCode == groupCode);
            if (groupToUpdate == null)
            {
                Console.WriteLine("This group was not found.");
                return;
            }
            groupToUpdate.AssignTeacher(teacher);
        }

        public void AddMentor(string groupCode, Mentor mentor)
        {
            Group groupToUpdate = Groups.Find(g => g.GroupCode == groupCode);
            if (groupToUpdate == null)
            {
                Console.WriteLine("This group was not found.");
                return;
            }
            groupToUpdate.AssignMentor(mentor);
        }

        public void AddStudent(string groupCode, Student student)
        {
            Group groupToUpdate = Groups.Find(g => g.GroupCode == groupCode);
            if (groupToUpdate == null)
            {
                Console.WriteLine("This group was not found.");
                return;
            }
            groupToUpdate.AssignStudent(student);
            student.Group = groupToUpdate;
        }
    }
}