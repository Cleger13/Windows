using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows
{
    class Person
    {
        public string name = "";
        public int age = 0;

        public Person(string name, int age = 0)
        {
            this.name = name;
        }

        class Student : Person
        {
            public Student(string name, int age = 0) : base(name, age)
            {
            }
        }

        class Teacher : Person
        {
            public Teacher(string name, int age = 0) : base(name, age)
            {
            }
        }
    }
}
