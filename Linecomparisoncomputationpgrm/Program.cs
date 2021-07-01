using System;

namespace Linecomparisoncomputationpgrm
{
    class Line
    {
        public int x1, x2, y1, y2;
        public double length;
        public string Name;
        public Line(string Name)
        {
            this.Name = Name;
            this.x1 = 0;
            this.x2 = 0;
            this.y1 = 0;
            this.y2 = 0;
            this.length = 0;


        }
    }
}
