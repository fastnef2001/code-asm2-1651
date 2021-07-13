using System;
using System.Collections.Generic;
using System.Text;

namespace nhanh
{
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public  Person() { }
        public Person(int id, string name, string gender, int age)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Age = age;
        }

    }
}
