using objControl;
using System;
using System.IO;

namespace XbeScan
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Out.WriteLine("Xbe Scan requires a filelist file");
                Console.Out.WriteLine("Multiply 2 X 7 =" + bin2Obj.Multiply(2, 7));
                string file = "VIVA";
                if (File.Exists(file))
                {
                    BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open));

                    byte[] blob = bin2Obj.getByteFullArray(reader.BaseStream);
                    Console.Out.WriteLine("length of " + file + " is: " + blob.LongLength.ToString() + " bytes");
                    Console.Out.WriteLine("first 16 bytes : " + readBytes(blob, 16));

                }
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

        private static string readBytes(byte[] blob, int v)
        {
            byte[] rValue = new byte[1 * v];
            for (int i = 0; i < v; i++)
            {
                rValue[i] = blob[i];
            }
            return System.Text.Encoding.UTF8.GetString(rValue);
              
        }
    }
}
