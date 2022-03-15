namespace Teste3.Classes
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int num, string titular, double saldo)
            : base(num, titular, saldo)
        {
            Num = num;
            Titular = titular;
            Saldo = saldo;
        }
        public override double Rendimento()
        {
            var rendimentoContaCorrente = Saldo * 0.05;
            var manutencao = -0.75;
            Saldo += rendimentoContaCorrente + manutencao;
            return rendimentoContaCorrente;
        }
        public override string ToString()
        {
            return "Número da conta: " + this.Num + " Titular: " + this.Titular + " Saldo: " + this.Saldo + "R$";
        }
    }
}
