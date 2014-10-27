using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MVCApplication.Tests
{
    [TestClass]
    public abstract class UnitTestBase
    {
        [ClassInitialize]
        public void Initialize()
        {

        }
    }
}
