using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {

            Program.getCartesian();
        }
        static void getCartesian()
        {
            double x1, x2, y1, y2, a1, a2, b1, b2;
            double Line1 = 0;
            double Line2 = 0;

            Console.WriteLine("Enter the point 1 (x1, y1) : ");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the point 2 (x2, y2) : ");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Line1 = Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
            Console.WriteLine("Lenth of first Line is: " + Line1);

            Console.WriteLine("Enter the point 1 (a1, b1) : ");
            a1 = double.Parse(Console.ReadLine());
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the point 2 (a2, b2) : ");
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());
            Line2 = Math.Sqrt(((a2 - a1) * (a2 - a1) + (b2 - y1) * (b2 - b1)));
            Console.WriteLine("Lenth of second Line is:" + Line2);

            if (Line1 == Line2)
            {
                Console.WriteLine("The Two Lines are equal:");
            }
            else
                Console.WriteLine("Two Lines are not Equal:");
        }
    }

}