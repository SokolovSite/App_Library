using System;


namespace ClassLibrary
{
    public class LibraryClass
    {
        public interface IFigure //интерфес для зависимости
        {
            double CalculateArea(); //метод для подсчета площади в зависимости от фигуры
        }

        public class Circle : IFigure //класс подсчета площади круга
        {
           
            private double radius;
            public Circle(double radius)
            {
                this.radius = radius;

                if (radius <= 0)
                {
                    throw new Exception("Радиус не может быть отрицательным или равен 0");
                }
                
            }

            public double CalculateArea()
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }

        public class Triangle : IFigure //класс подсчета площади треугольника и проверка сторон
        {
            private double side1;
            private double side2;
            private double side3;

            public Triangle(double side1, double side2, double side3)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;

                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    throw new Exception("Сторона не может быть равна 0 или отрицательна");
                }
            }

            public double CalculateArea()
            {
                
                double p = (side1 + side2 + side3) / 2;
                return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));

                }

            public bool RightTriangle() // проверка на прямоуголный теугольник
            {
                double[] sides = { side1, side2, side3 };

                Array.Sort(sides); //сортирока сторон на поиск большей и меньших 

                return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(side1, 2);
            }

        }
    }
}
