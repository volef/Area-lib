using Area.Figures;
using System;
using Area.Figures.Basic;

namespace Area
{
    public static class Area
    {
        public static double GetArea(IPolygon polygon)
        {
            var lines = polygon.GetLines();
            if (lines?.Count > 2)
            {
                var s = 0d;
                foreach (var line in polygon.GetLines())
                {
                    s += line.A.X * line.B.Y - line.A.Y * line.B.X;
                }
                return Math.Abs(s/2);
            }
            else
                throw new ArgumentException("Poligon must have more than 2 lines");
        }
        
        public static double GetArea(Circle circle)
        {
            return Math.PI * circle.Radius * circle.Radius;
        }
    }
}
