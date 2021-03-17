using System;

namespace Area.Figures.Basic
{
    
    public class Dot
    {
        public const double ToleranceDouble = 0.0000001;
        public double X { get; set; }
        public double Y { get; set; }

        public Dot(double x, double y)
        {
            X = x;
            Y = y;
        }
        
        public static bool operator !=(Dot first,Dot second)
        {
            if (first is null || second is null)
                return false;
            return Math.Abs(first.X - second.X) > ToleranceDouble || Math.Abs(first.Y - first.Y) > ToleranceDouble;

        }

        public static bool operator ==(Dot first, Dot second)
        {
            if (first is null || second is null)
                return false;
            return Math.Abs(first.X - second.X) < ToleranceDouble && Math.Abs(first.Y - first.Y) < ToleranceDouble;
        }
    }
}
