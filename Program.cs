using System;
using System.Text;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
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
                        ListarContas();
                        Console.WriteLine();
                        break;
                    case "2":
                        InserirConta();
                        Console.WriteLine();
                        break;
                    case "3":
                        Transferir();
                        Console.WriteLine();
                        break;
                    case "4":
                        Sacar();
                        Console.WriteLine();
                        break;
                    case "5":
                        Depositar();
                        Console.WriteLine();
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
        private static void ListarContas()
        {
            CustomConsole.WriteLine("Listar contas...");

            if (listContas.Count == 0)
            {
                CustomConsole.WriteLine("Nenhuma conta cadastrada.");
                return;
            }
            foreach (var conta in listContas)
            {
                CustomConsole.Write($"#{listContas.IndexOf(conta)} - ");
                CustomConsole.WriteLine(conta.ToString());
            }
        }
        private static void InserirConta()
        {
            Int32 tipoConta;
            String nome;
            Double saldo;
            Double credito;

            CustomConsole.WriteLine("Inserir nova conta...");
            Console.WriteLine();
            do
                CustomConsole.Write("Digite 0 para Conta Fisica ou 1 para Juridica: ");
            while (!Int32.TryParse(Console.ReadLine(), out tipoConta) || (tipoConta != 0 && tipoConta != 1));
            do
                CustomConsole.Write("Digite o Nome do Cliente: ");
            while (Double.TryParse(nome = CustomConsole.StripWhiteSpace(Console.ReadLine()), out double n));

            do
                CustomConsole.Write("Digite o saldo inicial: ");
            while (!Double.TryParse(Console.ReadLine(), out saldo) || saldo < 0);

            do
                CustomConsole.Write("Digite o crédito: ");
            while (!Double.TryParse(Console.ReadLine(), out credito) || credito < 0);

            Conta novaConta = new Conta(
                tipoConta: (TipoConta)tipoConta,
                nome: nome,
                saldo: saldo,
                credito: credito);

            listContas.Add(novaConta);
            CustomConsole.WriteLine($"Conta de {nome} inserida com sucesso!");
        }
        private static void Transferir()
        {
            CustomConsole.Write("Digite o número da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            CustomConsole.Write("Digite o número da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            CustomConsole.Write("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
        }
        private static void Sacar()
        {
            CustomConsole.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            CustomConsole.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorSaque);
        }
        private static void Depositar()
        {
            CustomConsole.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            CustomConsole.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
        }
    }
}
