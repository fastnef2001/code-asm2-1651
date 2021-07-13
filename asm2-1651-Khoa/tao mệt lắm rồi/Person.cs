using System;
using System.Collections.Generic;
using System.Text;

namespace tao_mệt_lắm_rồi
{
    class Person
    {
        //khai bao thuoc tinh
        string id, name, gender, birthday;
        //phuong thuc nhap thong tin
        protected void Accept(string id)
        {
            this.id = id;
            Console.WriteLine("**********************************************************");
                Console.Write("**Enter name               : ");
            this.name = Console.ReadLine();
                Console.Write("**Enter gender             : ");
            this.gender = Console.ReadLine();
                Console.Write("**Enter day of birth       : ");
            this.birthday = Console.ReadLine();         
        }    

        //phuong thuc hien thi thong tin
        protected void Display1()
        {

            Console.Write("{0, -2} {1, -10} {2, -6} {3, -6}",
                               "ID", "Name", "Gender", "Birthday");
            
           

        }
        
        protected void Display2()
        {
            Console.Write("{0, -2} {1, -10} {2, -6} {3, -6}",
                                     this.id, this.name, this.gender, this.birthday);

        }
        

    }
}
