using System;

namespace Area.Figures.Basic
{
    public class Line
    {
        private Dot _a;
        private Dot _b;

        public Dot A
        {
            get => _a;
            set => _a = value ?? throw new NullReferenceException("Dot A cannot be null");
        }

        public Dot B
        {
            get => _b;
            set => _b = value ?? throw new NullReferenceException("Dot B cannot be null");
        }

        public Line(Dot a, Dot b)
        {
            A = a;
            B = b;
        }
        
        public double Length() => Math.Sqrt(Math.Pow(B.X-A.X,2) + Math.Pow(B.Y-A.Y,2));
    }
}
