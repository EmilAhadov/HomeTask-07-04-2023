using System;

namespace OOP2
{
    internal partial class Program
    {
        //Task1
        interface ICalculateable
        {
           
            void CalculateArea();
            void CalculatePerimetr();
        }

        class Triangle : ICalculateable
        {
            private int _h;
            private int _a;
            public Triangle(int h,int a)
            {
                _h= h;
                _a= a;
            }
            public void CalculateArea()
            {
                Console.WriteLine(_a*_h/2);
            }

            public void CalculatePerimetr()
            {
                Console.WriteLine(_a * 3);
            }
        }
        class Circle : ICalculateable
        {
            public const double _PI = 3.14;
            public double _r;
            public Circle(double r) 
            {
                _r= r;
            }

            public void CalculateArea()
            {
                Console.WriteLine(_PI*_r*_r);
            }

            public void CalculatePerimetr()
            {
                Console.WriteLine(_PI * 2 * _r);
            }
        }
        class Square : ICalculateable
        {
            public double _a;
            public Square(double a)
            {
                _a = a;
            }
            public void CalculateArea()
            {
                Console.WriteLine(_a*_a);
            }

            public void CalculatePerimetr()
            {
                Console.WriteLine(_a * 4);
            }
        }
    }
}
