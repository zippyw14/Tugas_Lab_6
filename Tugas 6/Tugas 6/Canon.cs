using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_6
{
    class Canon : Printer
    {
        public override void show()
        {
            Console.WriteLine("canon   display dimension 9.5*12");
        }

        public override void print()
        {

            Console.WriteLine("canon  printet printing....");
        }
    }
}
