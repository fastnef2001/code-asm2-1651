using System;
using System.Collections.Generic;
using System.Text;

namespace nhanh
{
    class Menu
    {
        public void LoginMenu()
        {
            int teacherChoice = 1;
            Teacher Teacher = new Teacher();
            Teacher onlineTeacher = null;
            int id;
            string username;
            string gender;
            int age;
            string password;
            while (teacherChoice != 0)
            {
                Console.WriteLine("_____________________________");
                Console.WriteLine("||     1 : Sign up         ||");
                Console.WriteLine("||     2 : Login           ||");
                Console.WriteLine("||     0 : Exit            ||");
                Console.WriteLine("-----------------------------");
                teacherChoice = int.Parse(Console.ReadLine());

                switch (teacherChoice)
                {
                    case 1:
                        id = Utility.GetID();
                        username = Utility.GetUsername();
                        gender = Utility.GetGender();
                        age = Utility.GetAge();
                        password = Utility.GetPassword();
                        Teacher teacher = new Teacher(id, username,gender,age, password);
                        Teacher.AddNewTeacher(teacher);
                        break;
                    case 2:
                        onlineTeacher = Teacher.Login();
                        break;
                    case 3:
                        onlineTeacher = Teacher.Logout();
                        Console.WriteLine("Logout successfully !!!");
                        break;
                    default:
                        Console.WriteLine("Moi nhap lai!");
                        break;
                    case 0:
                        return;
                }
            }
        }


    public void SortMenu()
        {
            Student studentManagement = new Student();
            while (true)
            {
                Console.WriteLine("**********************FUNCTIONS********************");
                Console.WriteLine("**    1. Sort student by GPA.                    **");
                Console.WriteLine("**    2. Sort student by Name.                   **");
                Console.WriteLine("**    3. Sort student by ID.                     **");
                Console.WriteLine("**    0.                 EXIT                    **");
                Console.WriteLine("***************************************************");

                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        if (studentManagement.NumberOfStudents() > 0)
                        {
                            Console.WriteLine("\n***************5.Sort student by GPA***************");
                            studentManagement.SortByGPA();
                            studentManagement.DisplayStudent(studentManagement.getListStudent());
                        }
                        else
                        {
                            Console.WriteLine("\n************List of students is empty!*************");
                        }
                        break;
                    case 2:
                        if (studentManagement.NumberOfStudents() > 0)
                        {
                            Console.WriteLine("\n**************6.Sort student by Name***************");
                            studentManagement.SortByName();
                            studentManagement.DisplayStudent(studentManagement.getListStudent());
                        }
                        else
                        {
                            Console.WriteLine("\n************List of students is empty!*************");
                        }
                        break;
                    case 3:
                        if (studentManagement.NumberOfStudents() > 0)
                        {
                            Console.WriteLine("\n***************7.Sort student by ID****************");
                            studentManagement.SortByID();
                            studentManagement.DisplayStudent(studentManagement.getListStudent());
                        }
                        else
                        {
                            Console.WriteLine("\n************List of students is empty!*************");
                        }
                        break;
                    case 0:
                        Console.WriteLine("\n*****************You want to back MENU*****************");
                        MainMenu();
                        break;
                }

            }
        }
    

    public void MainMenu()
        { Student studentManagement = new Student();
            while (true)
            {   Console.WriteLine("\n------------STUDENT MANAGEMENT SYSTEM--------------\n");
                Console.WriteLine("**********************FUNCTIONS********************");
                Console.WriteLine("**    1. Add new student.                        **");
                Console.WriteLine("**    2. Update student's information by ID.     **");
                Console.WriteLine("**    3. Delete student by ID.                   **");
                Console.WriteLine("**    4. Find student by Name.                   **");
                Console.WriteLine("**                                               **");
                Console.WriteLine("**    5.SORT LIST OF STUDENTS:                  **");
                Console.WriteLine("**                                               **");
                Console.WriteLine("**    0.                 EXIT                    **");
                Console.WriteLine("***************************************************");
                Console.Write("\n           LET CHOOSE FUNCTION YOU WANT: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n*****************1.ADD NEW STUDENT*****************\n");
                        studentManagement.EnterStudent();
                        Console.WriteLine("\n**********Added new student successfully!**********");
                        break;
                    case 2:
                        if (studentManagement.NumberOfStudents() > 0)
                        {
                            int id;
                            Console.WriteLine("\n*******2.UPDATE STUDENT'S INFORMATION BY ID********");
                            Console.Write("                      Enter ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            studentManagement.UpdateStudent(id);
                            Console.WriteLine("\n*****Update student's information successfully!****");

                        }
                        else
                        {
                            Console.WriteLine("\n************List of students is empty!*************");
                        }break;
                    case 3:
                        if (studentManagement.NumberOfStudents() > 0)
                        {
                            int id;
                            Console.WriteLine("\n***************3.Delete student by ID**************");
                            Console.Write("                       Enter ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            if (studentManagement.DeleteById(id))
                            {
                                Console.WriteLine("\n************Student with ID = {0} deleted************", id);
                            }
                        }else
                        {
                            Console.WriteLine("\n************List of students is empty!*************");
                        }break;
                    case 4:
                        if (studentManagement.NumberOfStudents() > 0)
                        {
                            Console.WriteLine("\n**************4.Find student by Name***************");
                            Console.Write("                     Enter name: ");
                            string name = Convert.ToString(Console.ReadLine());
                            List<Student> searchResult = studentManagement.FindByName(name);
                            studentManagement.DisplayStudent(searchResult);
                        }else
                        {
                            Console.WriteLine("\n************List of students is empty!*************");
                        }
                        break;
                    case 5:
                        SortMenu();
                        break;
                    case 0:
                        Console.WriteLine("\n*****************You chose to Exit*****************");
                        return;
                    default:
                        Console.WriteLine("\n***************************************************");
                        Console.WriteLine("**               No this function!               **");
                        Console.Write("**           Let choose funtions in box          **");
                        Console.WriteLine("\n***************************************************");
                        break;
                }
            }
        }
    }
}
