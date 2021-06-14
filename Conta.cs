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
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito;
			return retorno;
		}
        public void MostrarSaldo()
        {
            CustomConsole.WriteLine($"Saldo atual da conta de {Nome} é {Saldo}");
        }
        public bool Sacar(double valor)
        {
            var saldoInsuficiente = (Saldo - valor < (Credito * -1));
            if (saldoInsuficiente)
            {
                CustomConsole.WriteLine("Saldo insuficiente!");
                return false;
            }

            Saldo -= valor;
            MostrarSaldo();
            return true;
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
            MostrarSaldo();
        }
        public void Transferir(double valor, Conta destino)
        {
            if (Sacar(valor)) destino.Depositar(valor);
        }
    }
    public enum TipoConta
    {
        PessoaFisica = 0,
        PessoaJuridica = 2
    }
}