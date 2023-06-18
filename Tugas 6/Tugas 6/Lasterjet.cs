using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_6
{
    class LasterJet : Printer
    {
        public override void show()
        {
            Console.WriteLine("LasterJet display dimension 10*11");
        }

        public override void print()
        {

            Console.WriteLine("LasterJet printet printing....");
        }
    }
}
