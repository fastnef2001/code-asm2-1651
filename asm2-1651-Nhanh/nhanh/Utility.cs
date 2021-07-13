using System;
using System.Collections.Generic;
using System.Text;

namespace nhanh
{
    class Utility
    {
        public static int GetID()
        {
            Console.WriteLine("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }
        public static string GetUsername()
        {
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            return username;
        }
        public static string GetGender()
        {
            Console.WriteLine("Enter gender: ");
            string gender = Console.ReadLine();
            return gender;
        }
        public static int GetAge()
        {
            Console.WriteLine("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            return age;
        }
        public static string GetPassword()
        {
            Console.Write("Enter your password please: ");
            StringBuilder passwordBuilder = new StringBuilder();
            bool continueReading = true;
            char newLineChar = '\r';
            while (continueReading)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                char passwordChar = consoleKeyInfo.KeyChar;
                if (consoleKeyInfo.Key == ConsoleKey.Enter)
                {
                    continueReading = false;
                    break;
                }
                Console.Write("*");
                if (passwordChar == newLineChar)
                {
                    continueReading = false;
                }
                else
                {
                    passwordBuilder.Append(passwordChar.ToString());
                }
            }
            Console.Write('\n');
            return passwordBuilder.ToString();
        }
        
    }
}
