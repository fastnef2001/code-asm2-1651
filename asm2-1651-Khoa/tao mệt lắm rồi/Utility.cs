using System;
using System.Collections.Generic;
using System.Text;

namespace tao_mệt_lắm_rồi
{
    class Utility
    {
        // Method

        public static string GetUsername()
        {
            Console.Write("Enter username            : ");
            string username = Console.ReadLine();
            return username;
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
