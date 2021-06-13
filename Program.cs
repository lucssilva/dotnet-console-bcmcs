using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomConsole.WriteLine("Seja bem-vindo ao BCMCS...");
            Console.WriteLine();
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        // ListarContas();
                        break;
                    case "2":
                        // InserirConta();
                        break;
                    case "3":
                        // Transferir();
                        break;
                    case "4":
                        // Sacar();
                        break;
                    case "5":
                        // Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            CustomConsole.WriteLine("Obrigado por utilizar nossos serviços.");
        }
        private static string ObterOpcaoUsuario()
        {
            CustomConsole.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Listar contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
