using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeworkUnitTests
{
    [TestClass]
    public class RectangleTests
    {
        classes.Task1_3.Rectangle testRectangle = new classes.Task1_3.Rectangle(new classes.Task1_3.Point(0, 0), new classes.Task1_3.Point(4, 5));

        [TestMethod]
        public void GetPerimeterTest()
        {
            double expectingResult = 18;

            double realResult = testRectangle.GetPerimeter();

            Assert.AreEqual(expectingResult, realResult);

        }

        [TestMethod]
        public void GetAreaTest()
        {
            double expectingResult = 20;

            double realResult = testRectangle.GetArea();

            Assert.AreEqual(expectingResult, realResult);
        }
    }

    [TestClass]
    public class CircleTests
    {
        classes.Task1_3.Circle testCircle = new classes.Task1_3.Circle();

        [TestMethod]
        public void GetLengthTest()
        {
            double expectingResult = 2 * 3.14 * 5;

            double realResult = testCircle.GetLength(5);

            Assert.AreEqual(expectingResult, realResult);
        }

        [TestMethod]
        public void GetAreaTest()
        {
            double expectingResult = 78.5d;

            double realResult = testCircle.GetArea(5);

            Assert.AreEqual(expectingResult, realResult);
        }
    }

    [TestClass]
    public class ComplexTests
    {
        classes.Task5.Complex complex1;
        classes.Task5.Complex complex2;

        [TestMethod]
        public void AddTest()
        {
            complex1 = new classes.Task5.Complex(1, 1.4d);
            complex2 = new classes.Task5.Complex(3, 1);

            classes.Task5.Complex expectingResult = new classes.Task5.Complex(4, 2.4d);

            classes.Task5.Complex realResult = complex1 + complex2;

            Assert.AreEqual(expectingResult.Real, realResult.Real);
            Assert.AreEqual(expectingResult.Imaginary, realResult.Imaginary);
        }

        [TestMethod]
        public void SubTest()
        {
            complex1 = new classes.Task5.Complex(3, -4);
            complex2 = new classes.Task5.Complex(5, 2);

            classes.Task5.Complex expectingResult = new classes.Task5.Complex(-2, -6);

            classes.Task5.Complex realResult = complex1 - complex2;

            Assert.AreEqual(expectingResult.Real, realResult.Real);
            Assert.AreEqual(expectingResult.Imaginary, realResult.Imaginary);
        }

        [TestMethod]
        public void MulTest()
        {
            complex1 = new classes.Task5.Complex(2, -3);
            complex2 = new classes.Task5.Complex(1, 5);

            classes.Task5.Complex expectingResult = new classes.Task5.Complex(17, 7);

            classes.Task5.Complex realResult = complex1 * complex2;

            Assert.AreEqual(expectingResult.Real, realResult.Real);
            Assert.AreEqual(expectingResult.Imaginary, realResult.Imaginary);
        }

        [TestMethod]
        public void DivTest()
        {
            complex1 = new classes.Task5.Complex(3, 2);
            complex2 = new classes.Task5.Complex(5, -3);

            classes.Task5.Complex expectingResult = new classes.Task5.Complex(9 / 34.0, 19 / 34.0);

            classes.Task5.Complex realResult = complex1 / complex2;

            Assert.AreEqual(expectingResult.Real, realResult.Real);
            Assert.AreEqual(expectingResult.Imaginary, realResult.Imaginary);
        }
    }
}
