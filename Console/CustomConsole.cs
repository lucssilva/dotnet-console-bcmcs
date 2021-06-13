using System;
using System.Threading;

namespace DIO.Bank
{
    public static class CustomConsole
    {
        public static void WriteLine(string args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(50));
                Console.Write(args[i]);
            }
            Console.WriteLine();
        }

    }
}