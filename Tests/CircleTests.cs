using System;
using Area.Figures;
using Area.Figures.Basic;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void GetCircleArea75dot5()
        {
            var circle = new Circle(new Dot(0d,0d),5d);
            
            Assert.AreEqual(78.5d,circle.GetArea(),0.1d);
        }
        
        [Test]
        public void CreateCircleBad()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Circle(new Dot(0d,0d),-5d);
            });
        }
    }
}