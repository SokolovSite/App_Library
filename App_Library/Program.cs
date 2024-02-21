using System;
using ClassLibrary;
using System.Threading;

namespace App_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LibraryClass.Circle circle = new LibraryClass.Circle(4);
                LibraryClass.Triangle triangle = new LibraryClass.Triangle(3, 4, 5);

                double circleArea = circle.CalculateArea();
                double triangleArea = triangle.CalculateArea();

                Console.WriteLine(circleArea);
                Console.WriteLine(triangleArea);
               
            }
            catch (Exception Exceptoin)
            {
                Console.WriteLine(Exceptoin.Message);
            }

            Console.ReadKey();
        }
    }
}
        
