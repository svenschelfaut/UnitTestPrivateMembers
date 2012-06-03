using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestPrivateMembers.Tests
{
    public partial class Employee
    {
        internal static class PrivateMemberNames
        {
            internal static readonly string Name = NameOf<Employee>.Member(x => x.Name);
            internal static readonly string lastName = NameOf<Employee>.Member(x => x.lastName);
        }
    }
}
