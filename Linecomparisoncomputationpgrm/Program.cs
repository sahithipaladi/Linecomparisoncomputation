using System;

namespace Linecomparisoncomputationpgrm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line Comparison Computation.");
            // Read the values of 2 Points (x1, y1) and (x2, y2)
            Console.WriteLine("Enter values x1 and y1 for Line 1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values x2 and y2 for Line 1");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values x3 and y3 for Line 2");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values x4 and y4 for Line 2");
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());
            double length_of_line1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double length_of_line2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            //the Length of 2 Points (x1, y1) and (x2, y2) is given
            if (length_of_line1.Equals(length_of_line2))
                Console.WriteLine("Lines are equal in length.");
            else
                Console.WriteLine("Lines are not equal in length.");
        }
    }
}
