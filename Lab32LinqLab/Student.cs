using System;
using System.Collections.Generic;
using System.Text;

namespace Lab32LinqLab
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Student()
        {

        }

    }
}
