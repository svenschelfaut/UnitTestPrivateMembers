using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestPrivateMembers.Tests
{
    public partial class Employee
    {
        private string lastName;
        public int Number { get; set; }
        private string Name { get; set; }
        public bool IsActive { get; private set; }
        public string Work() { return "Working..."; }
    }
}
