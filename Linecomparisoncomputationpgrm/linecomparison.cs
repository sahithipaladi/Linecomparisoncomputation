using System;
using System.Collections.Generic;
using System.Text;

namespace Linecomparisoncomputationpgrm
{
    class linecomparison
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n Line Comparison Computation.\n");
            // Read the values of 2 Points (x1, y1) and (x2, y2)
            Line line1 = new Line("Line-1");
            Line line2 = new Line("Line-2");
            Console.WriteLine("Enter values x1 and y1 for Line 1");
            line1.x1 = Convert.ToInt32(Console.ReadLine());
            line1.y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values x2 and y2 for Line 1");
            line1.x2 = Convert.ToInt32(Console.ReadLine());
            line1.y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values x1 and y1 for Line 2");
            line2.x1 = Convert.ToInt32(Console.ReadLine());
            line2.y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values x2 and y2 for Line 2");
            line2.x2 = Convert.ToInt32(Console.ReadLine());
            line2.y2 = Convert.ToInt32(Console.ReadLine());
            //the Length of 2 lines is given
            line1.length = Math.Sqrt(Math.Pow(line1.x2 - line1.x1, 2) + Math.Pow(line1.y2 - line1.y1, 2));
            line2.length = Math.Sqrt(Math.Pow(line2.x2 - line2.x1, 2) + Math.Pow(line2.y2 - line2.y1, 2));
            // Difference between line1 and line2 is given 
            int line_difference = line1.length.CompareTo(line2.length);
            if (line_difference == 0)
                Console.WriteLine("\n Lines are equal in length \n");
            else if (line_difference > 0)
                Console.WriteLine("\n Line1 is greater in length than Line2 \n");
            else
                Console.WriteLine("\nLine1 is smaller in length than Line2 \n");
        }
    }
}
