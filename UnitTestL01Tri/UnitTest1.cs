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

        [TestMethod]
        public void smallDifferencesBetweenSides()
        {
            Triangle tri = new Triangle(0.1, 0.2, 0.3);
            Assert.IsTrue(tri.isScalene());
        }

        [TestMethod]
        public void constructorDoubleArray()
        {
            double[] sides = new double[3] {1.5, 2.2, 3.8 };
            Triangle tri = new Triangle(sides);
            Assert.IsTrue(tri.isScalene());
        }

        [TestMethod]
        //Test av konstruktor som tar tre punkter på liksidig triangel
        public void constructorThreePoints()
        {
            Point pointOne = new Point(0, 0);
            Point pointTwo = new Point(0, 10);
            Point pointThree = new Point(10, 0);

            Triangle tri = new Triangle(pointOne, pointTwo, pointThree);
            Assert.IsTrue(tri.isIsosceles());
        }

        [TestMethod]
        public void constructorPointsArray()
        {
            Point pointOne = new Point(0, 0);
            Point pointTwo = new Point(0, 10);
            Point pointThree = new Point(10, 0);
            Point[] points = new Point[3] {pointOne, pointTwo, pointThree }; 

           Triangle tri = new Triangle(points);
           Assert.IsTrue(tri.isIsosceles());
        }
    }


}
