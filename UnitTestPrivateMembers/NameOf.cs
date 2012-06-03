using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestPrivateMembers
{
    public static class NameOf<T>
    {
        public static string Member(Expression<Func<T, object>> expression)
        {
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression == null)
            {
                var unaryExpression = expression.Body as UnaryExpression;
                if (unaryExpression == null)
                    throw new ArgumentException("memberExpression");

                memberExpression = unaryExpression.Operand as MemberExpression;
                if(memberExpression == null)
                    throw new ArgumentException("memberExpression");
            }

            return memberExpression.Member.Name;
        }
    }
}
