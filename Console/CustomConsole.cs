using System;
using System.Text;
using System.Threading;

namespace DIO.Bank
{
    public static class CustomConsole
    {
        public static void Write(string args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(50));
                Console.Write(args[i]);
            }
        }
        public static void WriteLine(string args)
        {
            Write(args);
            Console.WriteLine();
        }
        public static string StripWhiteSpace(string s)
        {
            // http://www.csharp411.com/remove-whitespace-from-c-strings/
            var sb = new StringBuilder();
            foreach (char c in s)
            {
                if (!char.IsWhiteSpace(c))
                    sb.Append(c);
            }
            return sb.ToString();
        }
    }
}