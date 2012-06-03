using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPrivateMembers.Tests
{
    [TestClass]
    public class ObjectExtensionsTest
    {
        [TestMethod]
        public void TestGetAndSetPrivateField()
        {
            var employee = new Employee();
            employee.SetMemberValue(Employee.PrivateMemberNames.lastName, "Boonen");

            var lastName = employee.GetMemberValue<string>(Employee.PrivateMemberNames.lastName);
            Assert.AreEqual("Boonen", lastName);
        }

        [TestMethod]
        public void TestGetAndSetPrivateProperty()
        {
            var employee = new Employee();
            employee.SetMemberValue(Employee.PrivateMemberNames.Name, "Tom");

            var name = employee.GetMemberValue<string>(Employee.PrivateMemberNames.Name);
            Assert.AreEqual("Tom", name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetMemberWrongType()
        {
            var employee = new Employee();
            employee.SetMemberValue(Employee.PrivateMemberNames.lastName, "Boonen");

            var lastName = employee.GetMemberValue<int>(Employee.PrivateMemberNames.lastName);
        }
    }
}
