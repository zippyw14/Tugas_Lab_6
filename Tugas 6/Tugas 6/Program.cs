using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_6
{
    class Program
    {
        public static Printer print;
        static void Main(string[] args)
        {
            Console.WriteLine("plih ini");
            Console.WriteLine("plih 1 Epson");
            Console.WriteLine("plih 2 Canon");
            Console.WriteLine("plih 3 LasterJet");
            Console.WriteLine("pilih 1-3");
            int pilh = Convert.ToInt32(Console.ReadLine());

            if (pilh == 1)
            {
                print = new Epson();
            }
            else if (pilh == 2)
            {
                print = new Canon();
            }
            else if (pilh == 3)
            {
                print = new LasterJet();
            }

            print.show();
            print.print();


            Console.ReadKey();




        }
    }
}
