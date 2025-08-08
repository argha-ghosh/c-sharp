using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInhertanceQ
{
    internal class GrandChild : Child
    {
        internal GrandChild()
        {
            Console.WriteLine("GrandChild D");  
        }

        internal override void M2()
        {
            Console.WriteLine("GrandChild M2");
        }

        internal override void M3()
        {
            Console.WriteLine("GrandChild M4");
        }

        internal override void M4()
        {
            Console.WriteLine("GrandChild M4");
        }

        internal override void M5()
        {
            Console.WriteLine("GrandChild M5");
        }

        internal sealed override void M6()
        {
            Console.WriteLine("GrandChild M6");
        }
    }
}
