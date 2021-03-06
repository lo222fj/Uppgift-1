﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestL01Tri
{
    [TestClass]
    public class TriangelUnitTest
    {
        [TestMethod]
        public void isIsoscelesTestTrue()
        {
            Triangle tri = new Triangle(1.0, 1.0, 0.5);
            Assert.IsTrue(tri.isIsosceles());
        }
        [TestMethod]
        public void isIsoscelesTestFalse()
        {
            Triangle tri = new Triangle(1.0, 1.5, 0.5);
            Assert.IsFalse(tri.isIsosceles());
        }
        
        [TestMethod]
        public void isEquilateralTestTrue()
        {
            Triangle tri = new Triangle(1.0, 1.0, 1.0);
            Assert.IsTrue(tri.isEquilateral());
        }

        [TestMethod]
        public void isEquilateralTestFalse()
        {
            Triangle tri = new Triangle(1.0, 2.0, 3.0);
            Assert.IsFalse(tri.isEquilateral());
        }

         [TestMethod]
        public void isScaleneTestTrue()
        {
            Triangle tri = new Triangle(1.0, 2.0, 3.0);
            Assert.IsTrue(tri.isScalene());
        }

         [TestMethod]
         public void isScaleneTestFalse()
         {
             Triangle tri = new Triangle(1.0, 2.0, 1.0);
             Assert.IsFalse(tri.isScalene());
         }

        [TestMethod]
        public void smallDifferencesBetweenSides()
        {
            Triangle tri = new Triangle(0.1, 0.2, 0.3);
            Assert.IsTrue(tri.isScalene());
        }

        [TestMethod]
        public void oneSideIsZero()
        {
            Triangle tri = new Triangle(0.0, 1.0, 1.0);
            Assert.IsTrue(tri.isIsosceles());
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
        public void constructorThreePointsIsosceles()
        {
            Point pointOne = new Point(0, 0);
            Point pointTwo = new Point(0, 10);
            Point pointThree = new Point(10, 0);

            Triangle tri = new Triangle(pointOne, pointTwo, pointThree);
            Assert.IsTrue(tri.isIsosceles());
        }
        [TestMethod]
        //Test av konstruktor som tar tre punkter på triangel m olika sidor
        public void constructorThreePointsScalene()
        {
            Point pointOne = new Point(0, 0);
            Point pointTwo = new Point(0, 5);
            Point pointThree = new Point(10, 0);

            Triangle tri = new Triangle(pointOne, pointTwo, pointThree);
            Assert.IsTrue(tri.isScalene());
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
