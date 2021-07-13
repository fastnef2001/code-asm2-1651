using System;
using System.Collections.Generic;
using System.Text;

namespace tao_mệt_lắm_rồi
{
    public class Admin
    {
       


            private string Name;
            private string Password;
            private List<Admin> Admins = new List<Admin>();
            Admin onlineAdmin;


            public Admin() { }
            public Admin(string name, string password)
            {

                Name = name;
                Password = password;

            }


            // Method
            public void AddNewAdmin(Admin admin)
            {
                Admins.Add(admin);
            }
        List<Teache> teacheLst = new List<Teache>();
        // danh sach khach hang
        List<Student> studentLst = new List<Student>();



        //mã
        int studentId = 0, teacherId = 0;
        public void EnterStudent()
        {

            Student student = new Student();
            studentId++;
            student.Accept("s" + studentId);
            studentLst.Add(student);
        }
        public void EnterTeacher()
        {
            Teache employee = new Teache();
            teacherId++;
            employee.Accept("t" + teacherId);
            teacheLst.Add(employee);
        }


        public void DisplayStudent()
        {
            foreach (Student stu in studentLst)
            {
                stu.Display();
            }
        }
        public void DisplayTeacher()
        {
            foreach (Teache tea in teacheLst)
            {
                tea.Display();
            }
        }

        public void tkPerson()
        {
            int FCnt = 0, PCnt = 0, MCnt = 0, DCnt = 0;
            foreach (Student cus in studentLst)
            {
                switch (cus.grade)
                {
                    case "F":
                        FCnt++;
                        break;
                    case "P":
                        PCnt++;
                        break;
                    case "M":
                        MCnt++;
                        break;
                    case "D":
                        DCnt++;
                        break;
                }
            }
            Console.WriteLine("\n*******************************************************");

            Console.WriteLine("Number of students got F garde: {0}", FCnt);
            Console.WriteLine("Number of students got P garde: {0}", PCnt);
            Console.WriteLine("Number of students got M garde: {0}", MCnt);
            Console.WriteLine("Number of students got D garde: {0}", DCnt);
            Console.WriteLine("*******************************************************\n");

        }
        
        public Admin Login()
        {
            string username = Utility.GetUsername();
            string password = Utility.GetPassword();
            Menu mn = new Menu();

            foreach (var teacher in Admins)
            {
                if (teacher.Name == username && teacher.Password == password)
                {
                    onlineAdmin = teacher;
                    Console.WriteLine("Login successfully !!!");
                    mn.MianMenu();
                    return teacher;


                }
            }
            Console.WriteLine("Username or password is invalid!!!");
            return null;
        }



        public Admin Logout()
        {
            onlineAdmin = null;
            return onlineAdmin;
        }

    }
    }  
