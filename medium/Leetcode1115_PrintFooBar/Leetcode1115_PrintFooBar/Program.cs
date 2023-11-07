using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode1115_PrintFooBar
{
    public class FooBar
    {
        private int n;
        readonly object LockHandler = new object();
        public FooBar(int n)
        {
            this.n = n;
        }

        public void Foo(Action printFoo)
        {
            for (int i = 0; i < n; i++)
            {
                lock (LockHandler)
                {
                    // printFoo() outputs "foo". Do not change or remove this line.
                    printFoo();
                }
                
            }
        }

        public void Bar(Action printBar)
        {

            for (int i = 0; i < n; i++)
            {

                lock (LockHandler)
                {
                    // printBar() outputs "bar". Do not change or remove this line.
                    printBar();
                }
            }
        }
    }
}
