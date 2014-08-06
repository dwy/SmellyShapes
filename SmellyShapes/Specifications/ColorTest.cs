using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SmellyShapes.Specifications
{
    using SmellyShapes.Source;

    [TestClass]
    public class ColorTest {

        [TestMethod]
        public void GetErrorMessage_InvalidColor() // throws Exception 
        {
            Color c = new Color("INVALIDColor_N4me");

            Assert.AreEqual("Color not recognized", c.GetErrorMessage());
        }

        [TestMethod]
        public void GetErrorMessage_Magenta() // throws Exception 
        {
            Color c = new Color("Magenta");

            Assert.AreEqual("Color not recognized", c.GetErrorMessage());
        }

        [TestMethod]
        public void GetErrorMessage_Cyan() // throws Exception 
        {
            Color c = new Color("Cyan");

            Assert.AreEqual("Color not recognized", c.GetErrorMessage());
        }


        [TestMethod]
        public void GetColorFormatted() // throws Exception 
        {
            Color c = new Color("Red");

            string formattedColor = c.GetColorFormatted(true);

            Assert.AreEqual("Red #FF0000 255:0:0", formattedColor);
        }

    }
}
