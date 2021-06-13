namespace DIO.Bank
{
    public class Conta
    {
        private string Nome { get; set; }
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        public Conta(string nome, TipoConta tipoConta, double saldo, double credito)
        {
            Nome = nome;
            TipoConta = tipoConta;
            Saldo = saldo;
            Credito = credito;
        }
        public override string ToString()
        {
            return "Conta de " + Nome;
        }
    }
}