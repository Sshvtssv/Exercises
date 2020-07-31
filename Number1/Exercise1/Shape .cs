using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace Exercise1
{
    public interface IShape
    {
        public double Area(); 
        
    }
    public class Rectangle : IShape
    {
        
        private readonly double area;
        public Rectangle(double side, double Side)
        {
            area = side * Side;
        }
        public double Area()
        {
            return area;
        }

    }

    public class Square : IShape
    {
        private readonly double side;
        public Square(double Side)
        {
            side = Side;
        }
        public double Area()
        {
            return side * side;
        }
        
    }
    class Program
    {
        static public void Figure(string fig, double s)
        {
            Console.WriteLine("{0} площадь = {1:##.###}", fig, s);
        }
        static void Main(string[] args)
        {
            Console.Write("Ширина фигуры = ");
            double Side = Convert.ToDouble(Console.ReadLine());
            Console.Write("Длина фигуры = ");
            double side = Convert.ToDouble(Console.ReadLine());
            Square square = new Square(Side);
            Figure("Квадрат: ", square.Area());
            Rectangle rectangle = new Rectangle(side, Side) ;
            Figure("Прямоугольник: ", rectangle.Area());
            Console.ReadKey();
        }
    }
}