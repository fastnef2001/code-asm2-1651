using System;
using System.Collections.Generic;
using System.Text;

namespace tao_mệt_lắm_rồi
{
    class Student:Person
    {
        public string grade;
        // nhap thong tin khach hang
        public new void Accept(string id)
        {
            base.Accept(id);
            Console.Write("**Enter grade (F, P, M, D) : ");
            this.grade = Console.ReadLine();
            Console.WriteLine("\n***********************Succeeded**********************");
        }

        // hiển thị thông tin khách hàng
        public new void Display()
        {
            
            Console.WriteLine("\n*******************************************************");
            base.Display1();
            Console.WriteLine("{0, 6}", "Grade");

            
            base.Display2();
            Console.WriteLine("{0, 6}", this.grade);
            Console.WriteLine("*******************************************************\n");
        }
    }
}
