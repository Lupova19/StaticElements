using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ваведи брой числа: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                double square = Koren.Square(num);
                Console.WriteLine(square);
            }

        }
    }
}
