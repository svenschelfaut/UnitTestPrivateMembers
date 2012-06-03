using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPrivateMembers.Tests
{
    [TestClass]
    public class NameOfTest
    {
        [TestMethod]
        public void TestNameOfPublicProperty()
        {
            var name = NameOf<Employee>.Member(x => x.IsActive);
            Assert.AreEqual("IsActive", name);
        }

        [TestMethod]
        public void TestNameOfPrivateProperty()
        {            
            Assert.AreEqual("Name", Employee.PrivateMemberNames.Name);
        }

        [TestMethod]
        public void TestNameOfPrivateField()
        {
            Assert.AreEqual("lastName", Employee.PrivateMemberNames.lastName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNameOfNoMemberExpression()
        {
            var name = NameOf<Employee>.Member(x => x.Work());
        }
    }


}
