using Microsoft.VisualStudio.TestTools.UnitTesting;

using SmellyShapes.Source;

namespace SmellyShapes.Specifications
{
    [TestClass]
    public class RectangleTest
    {

        private Rectangle rectangle;

        [TestInitialize]
        public void SetUp() // throws Exception 
        {
            this.rectangle = new Rectangle(0, 0, 2, 1);
        }

        [TestMethod]
        public void Contains() // throws Exception 
        {
            Assert.IsTrue(this.rectangle.Contains(0, 0));
            Assert.IsTrue(this.rectangle.Contains(1, 0));
            Assert.IsTrue(this.rectangle.Contains(1, 1));
            Assert.IsTrue(this.rectangle.Contains(2, 1));

            Assert.IsFalse(this.rectangle.Contains(2, 2));
            Assert.IsFalse(this.rectangle.Contains(-1, 0));
            Assert.IsFalse(this.rectangle.Contains(0, -1));
        }

        [TestMethod]
        public void CalculateArea() // throws Exception 
        {
            Assert.AreEqual(2, this.rectangle.Calculate());
        }

        [TestMethod]
        public void ToXml() // throws Exception 
        {
            string xml = this.rectangle.ToXml();

            Assert.AreEqual("<rectangle x=\"0\" y=\"0\" width=\"2\" height=\"1\" />\n", xml);
        }
    }
}

