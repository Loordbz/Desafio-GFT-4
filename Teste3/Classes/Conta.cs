namespace Teste3.Classes
{
    public abstract class Conta
    {
        public Conta(int num, string titular, double saldo)
        {
            Num = num;
            Titular = titular;
            Saldo = saldo;
        }
        public int Num { get; protected set; }
        public string Titular { get; protected set; }
        public double Saldo { get; protected set; }
        public abstract double Rendimento();
    }
}
