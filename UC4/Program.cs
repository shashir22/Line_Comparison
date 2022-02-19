using System;

namespace LineComparisonProblem
{
    class Program
    {
        static double length(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) * 1.0);
        }

        private static void compareToMethod(double l1, double l2)
        {


            if (l1.CompareTo(l2) == 0)
            {
                Console.WriteLine("Line1 is equal to Line2 ");
            }
            else if (l1.CompareTo(l2) < 0)
            {
                Console.WriteLine("Using compareTo method,Line1  is less than line2 ");
            }
            else
            {
                Console.WriteLine("Using compareTo method,Line1  is greater than Line2");
            }
        }

        private static void equalToMethod(double l1, double l2)
        {
            if (l1 == l2)
                Console.WriteLine("Lines are equal");
            else
                Console.WriteLine("Lines are  not equal");
            if (l1 > l2)
                Console.WriteLine("Using equalToMethod ,Line1  is greater than Line2  ");
            else if (l2 > l1)
                Console.WriteLine("Using equalToMethod,Line1  is less than line2  ");
        }


        static void Main(string[] args)
        {
            double line1, line2;

            line1 = (Math.Round(length(5, 6, 7, 3)));
            line2 = (Math.Round(length(3, 7, 8, 4)));
            Console.WriteLine(line1);
            Console.WriteLine(line2);

            equalToMethod(line1, line2);
            compareToMethod(line1, line2);
        }

    }
}

