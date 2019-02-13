using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Traning123
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(Kata.hexStringToRGB("#FF9933"),new List<int> {255,153,51 });
        }
        [Test]
        public void TestBlue()
        {
            Assert.AreEqual(Kata.hexStringToRGB("#4286f4"), new List<int> { 66, 134, 244 });
        }
        [Test]
        public void TestGreen()
        {
            Assert.AreEqual(Kata.hexStringToRGB("#92f441"), new List<int> { 146, 244, 65 });
        }
        [Test]
        public void TestWhite()
        {
            Assert.AreEqual(Kata.hexStringToRGB("#ffffff"), new List<int> { 255, 255, 255 });
        }
    }
}
