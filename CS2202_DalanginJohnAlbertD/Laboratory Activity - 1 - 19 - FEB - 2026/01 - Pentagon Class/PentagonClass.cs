
using System;


namespace PentagonClass
{
    class Pentagon
    {
        private Double side;
        public Pentagon()
        {
            side = 0;
        }

        public Pentagon(Double s)
        {
            side = s;
        }

        public Double GetArea()
        {
            return (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * side * side) / 4;
        }

        public Double GetPerimeter()
        {
            return 5 * side;
        }

        public void Display()
        {
            Console.WriteLine($"Perimeter: {GetPerimeter():0.000}");
            Console.WriteLine($"Area: {GetArea():0.000}");
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {   
            Console.WriteLine("Pentagon p1");
            Console.WriteLine("-------------------------");
            Console.Write("Side length: ");
            Double s = Convert.ToDouble(Console.ReadLine());
            Pentagon p1 = new Pentagon(s);
            p1.Display();

            Console.WriteLine("Pentagon p2");
            Console.WriteLine("-------------------------");
            Console.Write("Side length: ");
            Double s2 = Convert.ToDouble(Console.ReadLine());
            Pentagon p2 = new Pentagon(s2);
            p2.Display();

        }




    }
}
