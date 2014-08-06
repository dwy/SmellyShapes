using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SmellyShapes.Specifications
{
    using SmellyShapes.Source;

    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void CalculateArea()
        {
            Square square = new Square(0, 0, 2);
            Assert.AreEqual(4, square.Calculate());
        }

        [TestMethod]
        public void ToString_()
        {
            Square square = new Square(0, 0, 1, new Color("Red"));
            Assert.AreEqual("Square: (0:0) edgeLength=1 color=#FF0000", square.ToString());
        }

        [TestMethod]
        public void ToXml()
        {
            Square square = new Square(0, 1, 2);
            string xml = square.ToXml();
            Assert.AreEqual("<square x=\"0\" y=\"1\" edgeLength=\"2\" />\n", xml);
        }

        [TestMethod]
        public void ContainsPoints()
        {
            Square square = new Square(0, 0, 1);

            Assert.IsTrue(square.ContainsPoint(0, 0));
            Assert.IsTrue(square.ContainsPoint(0, 1));
            Assert.IsTrue(square.ContainsPoint(1, 1));
            Assert.IsTrue(square.ContainsPoint(1, 0));

            Assert.IsFalse(square.ContainsPoint(-1, -1));
            Assert.IsFalse(square.ContainsPoint(-1, 0));
            Assert.IsFalse(square.ContainsPoint(0, -1));
            Assert.IsFalse(square.ContainsPoint(1, 2));
            Assert.IsFalse(square.ContainsPoint(2, 1));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetHeigth()
        {
            new Square(0, 0, 0).GetHeight();
        }
    }
}
