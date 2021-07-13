using System;
using System.Collections.Generic;
using System.Text;

namespace tao_mệt_lắm_rồi
{
    class Menu
    {
        public void MianMenu()
        {
            Admin ad = new Admin();
            string option;
            //danh sach nhan vien

            do
            {
                //hien thi danh muc tinh nang cua chuong trinh
                Console.WriteLine("***************Student Management System***************\n");
                Console.WriteLine("************************FUNCTIONS**********************");
                Console.WriteLine("**                                                   **");
                Console.WriteLine("**        1. Add new student.                        **");
                Console.WriteLine("**        2. Add new teacher.                        **");
                Console.WriteLine("**        3. Display list of students.               **");
                Console.WriteLine("**        4. Display list of teachers.               **");
                Console.WriteLine("**        5. Count the number of students by grade   **");
                Console.WriteLine("**                                                   **");
                Console.WriteLine("**                       6. Exit                     **");
                Console.WriteLine("*******************************************************");

                Console.WriteLine("             LET CHOOSE A FUNTION YOU WANT:             ");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        ad.EnterStudent();
                        break;
                    case "2":
                        ad.EnterTeacher();
                        break;

                    case "3":
                        ad.DisplayStudent();
                        break;
                    case "4":
                        ad.DisplayTeacher();
                        break;

                    case "5":
                        ad.tkPerson();
                        break;
                }

            } while (!option.Equals("6"));

        }
        public void LoginMenu()
        { 
        int teacherChoice = 1;
        Admin Teacher = new Admin();
        Admin onlineTeacher = null;
        string username;
        string password;
            while (teacherChoice != 0)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("||   1 : Create new account   ||");
                Console.WriteLine("||   2 : Login                ||");
                Console.WriteLine("||   3 : Logout               ||");
                Console.WriteLine("||   0 : Exit                 ||");
                Console.WriteLine("--------------------------------");
                teacherChoice = int.Parse(Console.ReadLine());


                switch (teacherChoice)
                {

                    case 1:

                        username = Utility.GetUsername();
                        password = Utility.GetPassword();

                        Admin teacher = new Admin(username, password);
                        Teacher.AddNewAdmin(teacher);

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
    }
}
