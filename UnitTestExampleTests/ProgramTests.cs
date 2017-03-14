using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void HashingTest()
        {
            Assert.AreEqual(680131659347, Program.Hashing("leepadg"));
        }
    }
}