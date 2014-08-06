using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SmellyShapes.Specifications
{
    using SmellyShapes.Source;

    [TestClass]
    public class CircleTest
    {

        private Circle circle;

        [TestInitialize]
        public void SetUp()
        {
            this.circle = new Circle(0, 0, 1);
            this.circle.SetColor(new Color("Red"));
        }

        [TestMethod]
        public void Contains() // throws Exception 
        {
            Assert.IsTrue(this.circle.Contains(0, 0));
            Assert.IsTrue(this.circle.Contains(0, 1));
            Assert.IsTrue(this.circle.Contains(1, 0));

            Assert.IsFalse(this.circle.Contains(1, 1));
            Assert.IsFalse(this.circle.Contains(-1, -1));
            Assert.IsFalse(this.circle.Contains(1, -1));
            Assert.IsFalse(this.circle.Contains(-1, 1));

        }

        [TestMethod]
        public void CountContainingPoints() // throws Exception 
        {
            int result = this.circle.CountContainingPoints(new[] { 0, 10 }, new[] { 0, 10 });

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ToXml() // throws Exception 
        {
            string xml = this.circle.ToXml();

            Assert.AreEqual("<circle x=\"0\" y=\"0\" radius=\"1\" />\n", xml);
        }

        [TestMethod]
        public void ToString_() // throws Exception 
        {
            Assert.AreEqual("Circle: (0,0) radius= 1 RGB=255,0,0", this.circle.ToString());
        }
    }
}
