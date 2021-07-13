using System;
using System.Collections.Generic;
using System.Text;

namespace nhanh
{
    class Teacher:Person
    {
        private string Password;
        private List<Teacher> Teachers = new List<Teacher>();
        Teacher onlineTeacher;
        public Teacher():base() { }
        public Teacher(int id, string name,string gender, int age, string password):base(id, name, gender, age)
        {
            Password = password;
        }
        public void AddNewTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public Teacher Login()
        {
            string username = Utility.GetUsername();
            string password = Utility.GetPassword();
            Menu QL = new Menu();
            foreach (var teacher in Teachers)
            {
                if (teacher.Name == username && teacher.Password == password)
                {
                    onlineTeacher = teacher;
                    Console.WriteLine("Login successfully !!!");
                    QL.MainMenu();
                    return teacher;

                }
            }
            Console.WriteLine("Username or password is invalid!!!");
            return null;
        }
        public Teacher Logout()
        {
            onlineTeacher = null;
            return onlineTeacher;
        }
    }
}
