using System;

namespace Mybot.ChromeDevTools
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class EventAttribute : Attribute, IMethodNameAttribute
    {
        public EventAttribute(string methodName)
        {
            this.MethodName = methodName;
        }

        public string MethodName { get; private set; }
    }
}