using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XbeScan
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Out.WriteLine("Xbe Scan requires a filelist file");
                Console.ReadKey();
            }
            else
            {


                if (args[0] == "test.txt") { }

                Console.Out.WriteLine("Reading " + args[0]);
                switch (args[0])
                {
                    default:

                        break;
                }

                Console.ReadKey();
            }
        }

    }
}
