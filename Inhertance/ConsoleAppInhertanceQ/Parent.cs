using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInhertanceQ
{
    internal abstract class Parent //sealed
    {
        internal Parent() //: this("World")
        {
            Console.WriteLine("Parent D");
        }

        internal Parent(int y) : this()
        {
            Console.WriteLine("Parent NDC-" + y);
        }

        internal Parent(string y)
        {
            Console.WriteLine("Parent NDC-" + y);
        }

        internal void M1()
        {
            Console.WriteLine("Parent M1");
        }

        internal virtual void M2()
        {
            Console.WriteLine("Parent M2");
        }

        internal virtual void M3()
        {
            Console.WriteLine("Parent M3");
        }

        internal virtual void M4()
        {
            Console.WriteLine("Parent M4");
        }

        internal virtual void M5()
        {
            Console.WriteLine("Parent M5");
        }

        internal virtual void M6()
        {
            Console.WriteLine("Parent M6");
        }

        internal abstract void M7();
        //internal abstract string M8(double w);
    }
}
