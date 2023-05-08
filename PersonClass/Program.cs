using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Йордан", 21);
            Person person2 = new Person("Владимирa", 3);
            Person person3 = new Person("Иван", 28);
            Person person4 = new Person("Георги", 44);
            Person person5 = new Person("Ярослав", 5);

            Console.WriteLine($"Брой хора:{Person.Count}");
        }
    }
}
