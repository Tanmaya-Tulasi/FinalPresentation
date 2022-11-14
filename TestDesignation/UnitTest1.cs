using EmployeeManagementSystem.Core.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDesignation
{
    [TestClass]
    public class UnitTest1
    {
        private readonly string engineer;
        private readonly string dotnet;
        private readonly string abcd;

        [TestMethod]
        public void GetvyId()
        {
        }
        [TestMethod]
        public void GetAll()
        {
            var result = new DesignationRepository();
            var r =  result.GetDesignations();
            Assert.IsNotNull(r);
        }

        
    }
}
