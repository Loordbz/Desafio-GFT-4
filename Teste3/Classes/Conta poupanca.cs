namespace Teste3.Classes
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca(int num, string titular, double saldo)
            : base(num, titular, saldo)
        {
            Num = num;
            Titular = titular;
            Saldo = saldo;
        }
        public override double Rendimento()
        {
            var rendimentoContaPoupanca = Saldo * 0.07;
            Saldo += rendimentoContaPoupanca;
            return rendimentoContaPoupanca;
        }
        public override string ToString()
        {
            return "Número da conta: " + this.Num + " Titular: " + this.Titular + " Saldo: " + this.Saldo + "R$";
        }
    }
}
