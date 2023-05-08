using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи страна(side): ");
            double side  = double.Parse(Console.ReadLine());
            Console.Write("Въведи а: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ваведи b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ваведи r: ");
            double r = double.Parse(Console.ReadLine());

            double squarePerimeter = Geometry.SquarePerimeter(side);
            double squareArea = Geometry.SquareArea(side);
            double rectanglePerimeter = Geometry.RectanglePerimeter(a, b);
            double rectangleArea = Geometry.RectangleArea(a, b);
            double circleArea = Geometry.CircleArea(r);

            Console.WriteLine();
            Console.WriteLine($"Обиколка на квадрат: {squarePerimeter}");
            Console.WriteLine($"Лице на квадрат: {squareArea}");
            Console.WriteLine($"Обиколка на правоъгълник: {rectanglePerimeter}");
            Console.WriteLine($"Лице на правоъгълник: {rectangleArea}");
            Console.WriteLine($"Лице на кръг: {circleArea}");
        }
    }
}
