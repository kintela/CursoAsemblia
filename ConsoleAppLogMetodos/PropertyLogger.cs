using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace ConsoleAppLogMetodos
{
    public class PropertyLogger
    {        

        public void LogProperty<TResult>(Expression<Func<TResult>> property)
        {
            var memberExpression = (MemberExpression)property.Body;

            Console.WriteLine($"Property Name {memberExpression.Member.Name}");

        }

        public void LogMethod(Expression<Action> method)
        {
            if (method.Body.NodeType !=ExpressionType.Call)
            {
                return;
            }
            var methodCall = (MethodCallExpression)method.Body;
            var argumentnames = methodCall.Method.GetParameters().Select(p => p.Name);

            Console.WriteLine($"Method Name {methodCall.Method.Name}");
            Console.WriteLine($"Method Parameters {String.Join(",",argumentnames)}");

            //var action=method.Compile();
            //action();

            method.Compile()();

            Console.WriteLine("Method Called");

        }

        public void LogProperty2<TResult>(Func<TResult> property)
        {
            var value = property();

        }
    }
}
