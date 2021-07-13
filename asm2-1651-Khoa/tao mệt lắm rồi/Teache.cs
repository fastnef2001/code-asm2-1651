using System;
using System.Collections.Generic;
using System.Text;

namespace tao_mệt_lắm_rồi
{
    class Teache: Person
    {
        string speciality;
        
        //nhập thông tin nhân viên
        public new void Accept(string id)
        {
            base.Accept(id);
            Console.Write("**Enter speciality         : ");
            this.speciality = Console.ReadLine();
            Console.WriteLine("\n***********************Succeeded**********************");
        }
        // hiển thị thông tin nhân viên
        public new void Display()
        {
            Console.WriteLine("\n*******************************************************");
            base.Display1();
            Console.WriteLine("{0, 11}", "Speciality");


            base.Display2();
            Console.WriteLine("{0, 8}", this.speciality);
            Console.WriteLine("*******************************************************\n");
        }
    }
}
