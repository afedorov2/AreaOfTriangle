using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AreaOfTriangle.Tests
{
    [TestClass]
    public class FoundAreaTests
    {//проверка с нормальными длинами прямоуг. треугольника
        [TestMethod]
        public void areaOfTringle_10and20and30_100returned()
        {
            double width = 10;
            double height = 20;
            double hypotenuse = 30;
            double expected = 100;

            FoundArea fa = new FoundArea();
            double actual = fa.areaOfTringle(width, height, hypotenuse);

            Assert.AreEqual(expected, actual);
        }//проверка с отрицательными длинами прямоуг. треугольника
        [TestMethod]
        public void areaOfTringle_minus10andminus20and30_0returned()
        {
            double width = -10;
            double height = -20;
            double hypotenuse = 30;
            double expected = 0;

            FoundArea fa = new FoundArea();
            double actual = fa.areaOfTringle(width, height, hypotenuse);

            Assert.AreEqual(expected, actual);
        }
        //проверка с двумя одинаковыми сторонами больших третьей
        [TestMethod]
        public void areaOfTringle_30and20and30_0returned()
        {
            double width = 30;
            double height = 20;
            double hypotenuse = 30;
            double expected = 0;

            FoundArea fa = new FoundArea();
            double actual = fa.areaOfTringle(width, height, hypotenuse);

            Assert.AreEqual(expected, actual);
        }
        //проверка с нормальными длинами, но с неправильно
        //   передаваемыми параметрами
        [TestMethod]
        public void areaOfTringle_40and50and20_400returned()
        {
            double width = 40;
            double height = 50;
            double hypotenuse = 20;
            double expected = 400;

            FoundArea fa = new FoundArea();
            double actual = fa.areaOfTringle(width, height, hypotenuse);

            Assert.AreEqual(expected, actual);
        }
    }
}
