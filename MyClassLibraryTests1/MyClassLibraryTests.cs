using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary.Tests
{
    [TestClass()]
    public class MyClassLibraryTests
    {
        [TestMethod()]
        public void CircleAreaTest()
        {
            var cirkel = new Circle();
            cirkel.Radius = 5;

            Assert.AreEqual(Math.PI * 5 * 5, cirkel.Area);
        }

        [TestMethod()]
        public void CircleCircumferenceTest()
        {
            var cirkel = new Circle();
            cirkel.Radius = 5;

            Assert.AreEqual(Math.PI * 10, cirkel.Circumference);
        }
        
        [TestMethod()]
        public void RectangleAreaTest()
        {
            var rect = new Rectangle(10, 5);
            Assert.AreEqual(50, rect.Area);
        }

        [TestMethod()]
        public void StaffVolumeTest()
        {
            var staff = new Staff(10, 5 , 20);
            Assert.AreEqual(1000, staff.Volume);
        }
    }
}