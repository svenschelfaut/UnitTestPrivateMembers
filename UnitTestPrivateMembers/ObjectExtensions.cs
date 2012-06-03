using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPrivateMembers
{
    public static class ObjectExtensions
    {
        public static T GetMemberValue<T>(this object objectWithMember, string memberName)
        {
            PrivateObject privateObject = new PrivateObject(objectWithMember);
            var value = ValidateMemberName<T>(memberName, privateObject);
            return (T)value;
        }

        public static void SetMemberValue<T>(this object objectWithMember, string memberName, T value)
        {
            PrivateObject privateObject = new PrivateObject(objectWithMember);
            ValidateMemberName<T>(memberName, privateObject);
            privateObject.SetFieldOrProperty(memberName, value);
        }

        private static object ValidateMemberName<T>(string memberName, PrivateObject privateObject)
        {
            var value = privateObject.GetFieldOrProperty(memberName);
          
            if (value != null && value.GetType() != typeof(T))
            {
                throw new ArgumentException(
                    string.Format("Object has no member with type {0} and name {1}.", typeof(T).Name, memberName));
            }
            return value;
        }
    }
}
