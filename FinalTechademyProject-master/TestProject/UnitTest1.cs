using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetReturnsNotFound()
        {
            var mockRepository = new Mock<IEmployeeRepository>();
        }
    }
}
