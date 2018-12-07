using System;
using System.Collections.Generic;
using System.Text;

namespace CMD_Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            if (args.Length != 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
