using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeRedius()
        {
            IShape c = new Circle(-3);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ZeroRedius()
        {
            IShape c = new Circle(0);
        }
        [TestMethod()]
        public void PositiveRedius()
        {
            IShape c = new Circle(3);
        }
        [TestMethod()]
        public void GetArea()
        {
            IShape c = new Circle(2);
            Assert.AreEqual(Math.PI * 2 * 2, c.GetArea(), 0.0000000001);
        }
    }
}