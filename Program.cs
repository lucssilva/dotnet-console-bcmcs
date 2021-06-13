using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta("Lucas Silva", 0, 100, 5000);

            Console.WriteLine(conta);
        }
    }
}
