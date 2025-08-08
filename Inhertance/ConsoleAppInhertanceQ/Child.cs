using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInhertanceQ
{
    internal class Child : Parent
    {
        internal Child() //: base(70)
        {
            Console.WriteLine("Child D");
        }

        internal Child(int q) : this("Test")
        {
            Console.WriteLine("Child NDC-" + q);
        }

        internal Child(string q) : this()
        {
            Console.WriteLine("Child NDC-" + q);
        }

        internal void M1()
        {
            Console.WriteLine("Child M1");
        }

        internal override void M2()
        {
            Console.WriteLine("Child M2");
        }

        internal new virtual void M3()
        {
            Console.WriteLine("Child M3");
        }

        internal override void M6()
        {
            Console.WriteLine("Child M6");
        }

        internal override void M7()
        {
            Console.WriteLine("Child M7");
        }
    }
}
