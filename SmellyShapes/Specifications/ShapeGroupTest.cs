using Microsoft.VisualStudio.TestTools.UnitTesting;

using SmellyShapes.Source;

namespace SmellyShapes.Specifications
{
    [TestClass]
    public class ShapeGroupTest
    {

        [TestMethod]
        public void TooXml() // //throwsException 
        {
            ShapeGroup shapeGroup = new ShapeGroup();
            shapeGroup.Add(new Rectangle(0, 0, 2, 1));

            string xml = shapeGroup.ToXml();

            Assert.AreEqual(
                "<shapegroup>\n<rectangle x=\"0\" y=\"0\" width=\"2\" height=\"1\" />\n</shapegroup>\n",
                xml);
        }

        [TestMethod]
        public void Constructor_WithShapeArray() // //throwsException 
        {
            ShapeGroup shapeGroup = new ShapeGroup(new IShape[] { new Circle(0, 0, 0) }, true);

            Assert.AreEqual(1, shapeGroup.size);
        }

        [TestMethod]
        public void Add_WithReadOnly() // //throwsException 
        {
            ShapeGroup shapeGroup = new ShapeGroup();
            shapeGroup.SetReadOnly(true);

            shapeGroup.Add(new Circle(0, 0, 0));

            Assert.AreEqual(0, shapeGroup.size);
        }

        [TestMethod]
        public void Add_WithoutReadOnly() // //throwsException 
        {
            ShapeGroup shapeGroup = new ShapeGroup();
            shapeGroup.SetReadOnly(false);

            shapeGroup.Add(new Circle(0, 0, 0));

            Assert.AreEqual(1, shapeGroup.size);
        }

        [TestMethod]
        public void Add_SameElementTwice() //throwsException 
        {
            ShapeGroup shapeGroup = new ShapeGroup();
            shapeGroup.SetReadOnly(false);

            Circle circle = new Circle(0, 0, 0);
            shapeGroup.Add(circle);
            shapeGroup.Add(circle);

            Assert.AreEqual(1, shapeGroup.size);
        }

        [TestMethod]
        public void Add_InternalArraySizeExceeded() //throwsException 
        {
            ShapeGroup shapeGroup = new ShapeGroup();
            shapeGroup.SetReadOnly(false);

            for (int i = 0; i < 11; i++)
            {
                shapeGroup.Add(new Circle(0, 0, 0));
            }

            Assert.AreEqual(11, shapeGroup.size);
        }

        [TestMethod]
        public void Contains_PointNotInGroup() //throwsException 
        {
            ShapeGroup shapeGroup = new ShapeGroup();

            Assert.IsFalse(shapeGroup.Contains(0, 0));
        }

        [TestMethod]
        public void Contains_PointInGroup() //throwsException 
        {
            ShapeGroup shapeGroup = new ShapeGroup();
            shapeGroup.Add(new Circle(0, 0, 0));

            Assert.IsTrue(shapeGroup.Contains(0, 0));
        }

        [TestMethod]
        public void Contains_Null() //throwsException 
        {
            ShapeGroup shapeGroup = new ShapeGroup();

            Assert.IsFalse(shapeGroup.Contains(null));
        }

        [TestMethod]
        public void Contains_ShapeInGroup() //throwsException 
        {
            ShapeGroup shapeGroup = new ShapeGroup();
            Circle c = new Circle(0, 0, 0);
            shapeGroup.Add(c);

            Assert.IsTrue(shapeGroup.Contains(c));
        }
    }
}
