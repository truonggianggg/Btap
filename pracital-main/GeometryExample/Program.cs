using System;

namespace GeometryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of cylinder:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height of cylinder:");
            double height = Convert.ToDouble(Console.ReadLine());

            Cylinder cylinder = new Cylinder(radius, height);
            cylinder.Process();
            Console.WriteLine("Cylinder Result:");
            cylinder.Result();
        }
    }
}