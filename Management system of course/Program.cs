using System;

namespace Management_system_of_course
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupManagement groupManagement = new GroupManagement();
            MentorManagement mentorManagement = new MentorManagement();
            StudentManagement studentManagement = new StudentManagement();
            TeacherManagement teacherManagement = new TeacherManagement();

            while (true)
            {
                Console.WriteLine("Management System Menu:");
                Console.WriteLine("1. Group Management");
                Console.WriteLine("2. Mentor Management");
                Console.WriteLine("3. Student Management");
                Console.WriteLine("4. Teacher Management");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ManageGroups(groupManagement, teacherManagement, studentManagement, mentorManagement);
                        break;
                    case 2:
                        ManageMentors(mentorManagement);
                        break;
                    case 3:
                        ManageStudents(studentManagement);
                        break;
                    case 4:
                        ManageTeachers(teacherManagement);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }
            }
        }

        static void ManageGroups(GroupManagement groupManagement, TeacherManagement teacherManagement, StudentManagement studentManagement, MentorManagement mentorManagement)
        {
            while (true)
            {
                Console.WriteLine("\nGroup Management Menu:");
                Console.WriteLine("1. Add Group");
                Console.WriteLine("2. Modify Group");
                Console.WriteLine("3. Delete Group");
                Console.WriteLine("4. Display All Groups");
                Console.WriteLine("5. Add Teacher to Group");
                Console.WriteLine("6. Add Mentor to Group");
                Console.WriteLine("7. Add Student to Group");
                Console.WriteLine("8. Back to Main Menu");
                Console.Write("Select an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Group Code: ");
                        string groupCode = Console.ReadLine();
                        Console.Write("Enter Group Name: ");
                        string groupName = Console.ReadLine();
                        groupManagement.AddGroup(groupCode, groupName);
                        break;
                    case 2:
                        Console.Write("Enter Group Code: ");
                        string modGroupCode = Console.ReadLine();
                        Console.Write("Enter New Group Name: ");
                        string newGroupName = Console.ReadLine();
                        groupManagement.ModifyGroup(modGroupCode, newGroupName);
                        break;
                    case 3:
                        Console.Write("Enter Group Code: ");
                        string delGroupCode = Console.ReadLine();
                        groupManagement.DeleteGroup(delGroupCode);
                        break;
                    case 4:
                        groupManagement.DisplayAllGroups();
                        break;
                    case 5:
                        Console.Write("Enter Group Code: ");
                        string groupCodeForTeacher = Console.ReadLine();
                        Console.Write("Enter Teacher Number: ");
                        if (!int.TryParse(Console.ReadLine(), out int teacherNumber))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            break;
                        }
                        Teacher teacher = teacherManagement.Teachers.Find(t => t.TeacherNumber == teacherNumber);
                        if (teacher != null)
                        {
                            groupManagement.AddTeacher(groupCodeForTeacher, teacher);
                        }
                        else
                        {
                            Console.WriteLine("Teacher not found.");
                        }
                        break;
                    case 6:
                        Console.Write("Enter Group Code: ");
                        string groupCodeForMentor = Console.ReadLine();
                        Console.Write("Enter Mentor Number: ");
                        if (!int.TryParse(Console.ReadLine(), out int mentorNumber))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            break;
                        }
                        Mentor mentor = mentorManagement.Mentors.Find(m => m.NumberMentor == mentorNumber);
                        if (mentor != null)
                        {
                            groupManagement.AddMentor(groupCodeForMentor, mentor);
                        }
                        else
                        {
                            Console.WriteLine("Mentor not found.");
                        }
                        break;
                    case 7:
                        Console.Write("Enter Group Code: ");
                        string groupCodeForStudent = Console.ReadLine();
                        Console.Write("Enter Student Number: ");
                        if (!int.TryParse(Console.ReadLine(), out int studentNumber))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            break;
                        }
                        Student student = studentManagement.Students.Find(s => s.StudentNumber == studentNumber);
                        if (student != null)
                        {
                            groupManagement.AddStudent(groupCodeForStudent, student);
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;
                    case 8:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }
            }
        }

        static void ManageMentors(MentorManagement mentorManagement)
        {
            while (true)
            {
                Console.WriteLine("\nMentor Management Menu:");
                Console.WriteLine("1. Add Mentor");
                Console.WriteLine("2. Modify Mentor");
                Console.WriteLine("3. Delete Mentor");
                Console.WriteLine("4. Display All Mentors");
                Console.WriteLine("5. Back to Main Menu");
                Console.Write("Select an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Mentor Number to add:");
                        int mentorNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter Mentor Name:");
                        string mentorName = Console.ReadLine();
                        Console.Write("Enter Mentor Surname:");
                        string mentorSurname = Console.ReadLine();
                        mentorManagement.AddMentor(mentorNumber, mentorName, mentorSurname);
                        break;
                    case 2:
                        Console.Write("Enter Mentor Number to modify:");
                        int mentorNumberToModify = int.Parse(Console.ReadLine());
                        Console.Write("Enter new Mentor Name:");
                        string newMentorName = Console.ReadLine();
                        Console.Write("Enter new Mentor Surname:");
                        string newMentorSurname = Console.ReadLine();
                        mentorManagement.ModifyMentor(mentorNumberToModify, newMentorName, newMentorSurname);
                        break;
                    case 3:
                        Console.Write("Enter Mentor Number to remove:");
                        int mentorNumberToRemove = int.Parse(Console.ReadLine());
                        mentorManagement.RemoveMentor(mentorNumberToRemove);
                        break;
                    case 4:
                        mentorManagement.DisplayAllMentors();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }
            }
        }


        static void ManageStudents(StudentManagement studentManagement)
        {
            while (true)
            {
                Console.WriteLine("\nStudent Management Menu:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Modify Student");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Display All Students");
                Console.WriteLine("5. Back to Main Menu");
                Console.Write("Select an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        studentManagement.AddStudent();
                        break;
                    case 2:
                        Console.Write("Enter Student Number: ");
                        if (!int.TryParse(Console.ReadLine(), out int studentNumber))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            break;
                        }
                        Console.Write("Enter New Student Name: ");
                        string newStudentName = Console.ReadLine();
                        Console.Write("Enter New Student Surname: ");
                        string newStudentSurname = Console.ReadLine();
                        studentManagement.ModifyStudent(studentNumber, newStudentName, newStudentSurname);
                        break;
                    case 3:
                        studentManagement.RemoveStudent();
                        break;
                    case 4:
                        studentManagement.DisplayAllStudents();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }
            }
        }

        static void ManageTeachers(TeacherManagement teacherManagement)
        {
            while (true)
            {
                Console.WriteLine("\nTeacher Management Menu:");
                Console.WriteLine("1. Add Teacher");
                Console.WriteLine("2. Modify Teacher");
                Console.WriteLine("3. Delete Teacher");
                Console.WriteLine("4. Display All Teachers");
                Console.WriteLine("5. Back to Main Menu");
                Console.Write("Select an option: ");
                
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        teacherManagement.AddTeacher();
                        break;
                    case 2:
                        Console.Write("Enter Teacher Number: ");
                        if (!int.TryParse(Console.ReadLine(), out int teacherNumber))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            break;
                        }
                        Console.Write("Enter New Teacher Name: ");
                        string newTeacherName = Console.ReadLine();
                        Console.Write("Enter New Teacher Surname: ");
                        string newTeacherSurname = Console.ReadLine();
                        teacherManagement.ModifyTeacher(teacherNumber, newTeacherName, newTeacherSurname);
                        break;
                    case 3:
                        teacherManagement.RemoveTeacher();
                        break;
                    case 4:
                        teacherManagement.DisplayAllTeachers();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
