using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class AccessModifiers
    {
        public void Test1()
        {
            Console.WriteLine("Public ---Test1");
        }
        private void Test2()
        {
            Console.WriteLine("Private ---Test2");
        }
        protected void Test3()
        {
            Console.WriteLine("Protected ---Test3");
        }
        internal void Test4()
        {
            Console.WriteLine("internal ---Test4");
        }
        protected internal void Test5()
        {
            Console.WriteLine("protected internal ---Test5");
        }

    }
}
