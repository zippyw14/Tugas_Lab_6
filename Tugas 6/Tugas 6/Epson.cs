using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_6
{
    class Epson : Printer
    {

        public override void show()
        {
            Console.WriteLine("epson  display dimension 10*11");
        }

        public override void print()
        {

            Console.WriteLine("epson  printet printing....");
        }
    }
}
