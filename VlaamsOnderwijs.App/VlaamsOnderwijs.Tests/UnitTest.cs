using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using VlaamsOnderwijs.DAL;
using VlaamsOnderwijs.ef;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace VlaamsOnderwijs.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PassingTest()
        {
            Assert.Equals(4, Add(2,2));
        }

        [TestMethod]
        public void FailingTest()
        {
            Assert.Equals(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}


// You cannot unit test a UWP project, only a class library (at this time).
// https://github.com/PrismLibrary/Prism/issues/140