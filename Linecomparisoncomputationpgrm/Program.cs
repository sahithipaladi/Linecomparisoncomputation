using System;

namespace Linecomparisoncomputationpgrm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line Comparison Computation.");
            //A Length as 2 Points (x1, y1) and (x2, y2)
            // Read the values of 2 Points (x1, y1) and (x2, y2)
            Console.Write("Enter the value of x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of x2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of y2 : ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double length_of_line = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //the Length of 2 Points (x1, y1) and (x2, y2) is given
            Console.WriteLine("The Length of 2 Points(" + x1 + "," + y1 + ") and(" + x2 + "," + y2 + ") is " + length_of_line);
        }
    }
}
