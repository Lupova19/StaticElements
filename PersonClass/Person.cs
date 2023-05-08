using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    internal class Person
    {
        private string name;
        private int age;
        private static int staticField;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int StaticField
        {
            get { return staticField; }
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            staticField++;
        }
        public static int Count
        {
            get { return staticField; }
        }
    }
}
