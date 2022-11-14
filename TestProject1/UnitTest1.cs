using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Core.IRepository;
using EmployeeManagementSystem.Core.Repository;
using EmployeeManagementSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void ReturnNotFound()
        {

            var controller = new EmployeeRepository();
            var action = controller.GetById(999);
            var emp = new EmployeeRepository();
            var ne = emp.GetById(1);
            Assert.IsNotNull(ne);
            Assert.AreEqual(1, action.Id);
            Assert.IsInstanceOfType(action, typeof(Task<EmployeeModel>));
        }
        [TestMethod]
        public void ReturnOnDelete()
        {
            var emp = new EmployeeRepository();
            var e = emp.DeleteEmployee(1);

            // Assert.AreEqual(e, "Deleted Successfully");

            Assert.IsInstanceOfType(e, typeof(Task<EmployeeModel>));


        }


        [TestMethod]
        public void ReturnLeaveByID()
        {
            var hours = new RequestLeaveController();
            var hours1 = new RequestLeaveRepository();
            var h = hours1.GetLeave(99);
            Console.WriteLine(h);
            Assert.IsInstanceOfType(h, typeof(Task<RequestLeave>));
            var u = hours1.DeleteLeave(99);
            Assert.IsNotInstanceOfType(h, typeof(RequestLeave));
        }

        //[TestMethod]
        //public void GetPayById()
        //{
        //    var pay = new PaymentRulesController();
        //    var pay1 = new PaymentRulesRepository();
        //    var p = pay1.GetById(55);
        //    Console.WriteLine(p);
        //    Assert.IsInstanceOfType(p, typeof(Task<PaymentRulesModel>));
        //    var p1 = pay1.DeleteRule(55);
        //    Assert.IsNotInstanceOfType(p, typeof(PaymentRulesModel));
        //}



    }


}
