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
    public class TtriangleTests
    {
        [TestMethod()]
        public void Ttriangle_2_4_5()
        {
                IShape t = new Ttriangle(2, 4, 5);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void Ttriangle_NotExisting()
        {
                IShape t = new Ttriangle(1, 2, 3);
        }
        [TestMethod()]
        public void GetArea_2_5_4()
        {
            const double expected_area = 3.7996710384;
            IShape t = new Ttriangle(2, 5, 4);
            Assert.AreEqual(expected_area, t.GetArea(), 0.00000000001);
        }
        [TestMethod()]
        public void IsRight()
        {
            IShape t = new Ttriangle(3, 4, 5);
            Assert.AreEqual(true, ((Ttriangle)t).IsRight());
        }
        [TestMethod()]
        public void IsNotRight()
        {
            IShape t = new Ttriangle(3, 4, 6);
            Assert.AreEqual(false, ((Ttriangle)t).IsRight());
        }
    }
}