using System;
using System.Collections.Generic;
using Area.Figures;
using Area.Figures.Basic;
using NUnit.Framework;

namespace Tests
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateRectangularTriangle()
        {
            var lines = new List<Line>
            {
                new Line(new Dot(0d,0d),new Dot(0d,5d)),
                new Line(new Dot(0d,5d),new Dot(5d,5d)),
                new Line(new Dot(5d,5d),new Dot(0d,0d))
            };
            
            var triangle = new Triangle(lines);
            
            Assert.True(triangle.IsRectangular());
        }
        
        [Test]
        public void CreateTriangleBad()
        {
            var lines = new List<Line>
            {
                new Line(new Dot(0d,0d),new Dot(0d,5d)),
                new Line(new Dot(5d,5d),new Dot(5d,5d)),
                new Line(new Dot(5d,5d),new Dot(0d,0d))
            };
            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(lines);
            });
        }
        
        [Test]
        public void GetTriangleArea15dot5()
        {
            var lines = new List<Line>
            {
                new Line(new Dot(0d,0d),new Dot(0d,5d)),
                new Line(new Dot(0d,5d),new Dot(5d,5d)),
                new Line(new Dot(5d,5d),new Dot(0d,0d))
            };
            
            var triangle = new Triangle(lines);
            
            Assert.AreEqual(12.5d,triangle.GetArea());
        }
    }
}