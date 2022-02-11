using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PROG2070_A2_Armando_Interaminense;

namespace RectangleTest
{
    public class RectangleTest
    {
        [TestFixture]
        public class RectangleTest2 : RectangleTest
        {
            [Test]
            public void GetLength_Input2_OutputValidGetLength()
            {
                Rectangle rect = new Rectangle(2,2);
                int lengthExpected = 2;
                int lengthActual = rect.GetLength();
                Assert.AreEqual(lengthExpected, lengthActual);
            }
            [Test]
            public void GetLength_Input3_OutputValidGetLength()
            {
                Rectangle rect = new Rectangle(2, 3);
                int lengthExpected = 3;
                int lengthActual = rect.GetLength();
                Assert.AreEqual(lengthExpected, lengthActual);
            }
            [Test]
            public void GetLength_Input4_OutputValidGetLength()
            {
                Rectangle rect = new Rectangle(3, 4);
                int lengthExpected = 4;
                int lengthActual = rect.GetLength();
                Assert.AreEqual(lengthExpected, lengthActual);
            }
            [Test]
            public void SetLength_Input2_OutputValidSetLength()
            {
                Rectangle rectangle = new Rectangle(2, 3);
                int lengthExpected = 2;
                int lengthActual = rectangle.SetLength(2);
                Assert.AreEqual(lengthExpected, lengthActual); 
            }
            [Test]
            public void SetLength_Input3_OutputValidSetLength()
            {
                Rectangle rectangle = new Rectangle(2, 2);
                int lengthExpected = 3;
                int lengthActual = rectangle.SetLength(3);
                Assert.AreEqual(lengthExpected, lengthActual);
            }
            [Test]
            public void SetLength_Input4_OutputValidSetLength()
            {
                Rectangle rectangle = new Rectangle(2, 2);
                int lengthExpected = 4;
                int lengthActual = rectangle.SetLength(4);
                Assert.AreEqual(lengthExpected, lengthActual);
            }
            [Test]
            public void GetWidth_Input2_OutputValidGetWidth()
            {
                Rectangle rectangle = new Rectangle(2, 2);
                int widthExpected = 2;
                int widthActual = rectangle.GetWidth();
                Assert.AreEqual(widthExpected, widthActual);
            }
            [Test]
            public void GetWidth_Input3_OutputValidGetWidth()
            {
                Rectangle rectangle = new Rectangle(3, 3);
                int widthExpected = 3;
                int widthActual = rectangle.GetWidth();
                Assert.AreEqual(widthExpected, widthActual);
            }
            [Test]
            public void GetWidth_Input4_OutputValidGetWidth()
            {
                Rectangle rectangle = new Rectangle(4, 2);
                int widthExpected = 4;
                int widthActual = rectangle.GetWidth();
                Assert.AreEqual(widthExpected, widthActual);
            }
            [Test]
            public void SetWidth_Input2_OutputValidSetWidth()
            {
                Rectangle rectangle = new Rectangle(3, 2);
                int widthExpected = 2;
                int widthActual = rectangle.SetWidth(2);
                Assert.AreEqual(widthExpected, widthActual);
            }
            [Test]
            public void SetWidth_Input3_OutputValidSetWidth()
            {
                Rectangle rectangle = new Rectangle(2, 2);
                int widthExpected = 3;
                int widthActual = rectangle.SetWidth(3);
                Assert.AreEqual(widthExpected, widthActual);
            }
            [Test]
            public void SetWidth_Input4_OutputValidSetWidth()
            {
                Rectangle rectangle = new Rectangle(2, 2);
                int widthExpected = 4;
                int widthActual = rectangle.SetWidth(4);
                Assert.AreEqual(widthExpected, widthActual);
            }
            [Test]
            public void GetPerimeter_Input2and2_OutputValidPerimeter()
            {
                Rectangle rectangle = new Rectangle (2,2);
                int perimeterExpected = 8;
                int perimeterActual = rectangle.GetPerimeter();
                Assert.AreEqual(perimeterExpected, perimeterActual);
            }
            [Test]
            public void GetPerimeter_Input3and3_OutputValidPerimeter()
            {
                Rectangle rectangle = new Rectangle(3, 3);
                int perimeterExpected = 12;
                int perimeterActual = rectangle.GetPerimeter();
                Assert.AreEqual(perimeterExpected, perimeterActual);
            }
            [Test]
            public void GetPerimeter_Input4and4_OutputValidPerimeter()
            {
                Rectangle rectangle = new Rectangle(4, 4);
                int perimeterExpected = 16;
                int perimeterActual = rectangle.GetPerimeter();
                Assert.AreEqual(perimeterExpected, perimeterActual);
            }
            [Test]
            public void GetArea_Input2and2_OutputValidArea()
            {
                Rectangle rectangle = new Rectangle(2, 2);
                int areaExpected = 4;
                int areaActual = rectangle.GetArea();
                Assert.AreEqual(areaExpected, areaActual);
            }
            [Test]
            public void GetArea_Input3and3_OutputValidArea()
            {
                Rectangle rectangle = new Rectangle(3, 3);
                int areaExpected = 9;
                int areaActual = rectangle.GetArea();
                Assert.AreEqual(areaExpected, areaActual);
            }
            [Test]
            public void GetArea_Input4and4_OutputValidArea()
            {
                Rectangle rectangle = new Rectangle(4, 4);
                int areaExpected = 16;
                int areaActual = rectangle.GetArea();
                Assert.AreEqual(areaExpected, areaActual);
            }
        }
    }
}
