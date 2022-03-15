namespace Teste1.Classes
{
    public abstract class Colaborador
    {
        public Colaborador(string nome, int idade, double salario, int grauInstrucao)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
            GrauInstrucao = grauInstrucao;
        }
        public string Nome { get; protected set; }
        public int Idade { get; protected set; }
        public double Salario { get; protected set; }
        public int GrauInstrucao { get; protected set; }

        public abstract double Bonificacao();

    }
}
