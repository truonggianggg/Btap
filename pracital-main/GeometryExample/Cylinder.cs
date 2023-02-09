using System;
namespace GeometryExample
{
    public class Cylinder
    {
        private double radius;
        private double height;
        private double baseArea;
        private double lateralArea;
        private double totalArea;
        private double volume;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public void Process()
        {
            baseArea = radius * radius * Math.PI;
            lateralArea = 2 * Math.PI * radius * height;
            totalArea = 2 * Math.PI * radius * (height + radius);
            volume = Math.PI * radius * radius * height;
        }

        public void Result()
        {
            Console.WriteLine("Base Area: " + baseArea);
            Console.WriteLine("Lateral Area: " + lateralArea);
            Console.WriteLine("Total Area: " + totalArea);
            Console.WriteLine("Volume: " + volume);
        }
    }

}