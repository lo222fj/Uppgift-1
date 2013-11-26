using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestL01Tri
{
    [TestClass]
    public class TriangelUnitTest
    {
        [TestMethod]
        public void isIsoscelesTest()
        {
            Triangle tri = new Triangle(1.0, 1.0, 0.5);
            Assert.IsTrue(tri.isIsosceles());
        }

        [TestMethod]
        public void isEquilateralTest()
        {
            Triangle tri = new Triangle(1.0, 1.0, 1.0);
            Assert.IsTrue(tri.isEquilateral());
        }

        [TestMethod]
        public void isScaleneTest()
        {
            Triangle tri = new Triangle(1.0, 2.0, 3.0);
            Assert.IsTrue(tri.isScalene());
        }
    }
}
