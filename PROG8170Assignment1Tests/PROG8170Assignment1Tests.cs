using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PROG8170Assignment1;

namespace PROG8170Assignment1Tests
{
    [TestFixture]
    public class PROG8170Assignment1Tests
    {
        [Test]
        public void GetLengthTest()
        {
            Rectangle rec = new Rectangle(2, 3);
            
            int result = rec.GetLength();

            Assert.AreEqual(result, 2);
        }

        [Test]
        public void SetLengthTest()
        {
            Rectangle rec = new Rectangle(2, 3);
            
            rec.SetLength(5);
            int result = rec.GetLength();

            Assert.AreEqual(result, 5);
        }

        [Test]
        public void GetWidthTest()
        {
            Rectangle rec = new Rectangle(6, 4);
            int result = rec.GetWidth();

            Assert.AreEqual(result, 4);
        }

        [Test]
        public void SetWidthTest()
        {
            Rectangle rec = new Rectangle(6, 4);
            rec.SetWidth(1);
            int result = rec.GetWidth();

            Assert.AreEqual(result, 1);
        }
        
        [Test]
        public void GetPerimeterTest()
        {
            Rectangle rec = new Rectangle();
            int result = rec.GetPerimeter();

            Assert.AreEqual(result, 4);
        }

        [Test]
        public void GetAreaTest()
        {
            Rectangle rec = new Rectangle(8, 7);
            int result = rec.GetArea();

            Assert.AreEqual(result, 56);
        }
    }
}