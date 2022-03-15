namespace Teste1.Classes
{
    public class Supervisor : Colaborador
    {
        public Supervisor(string nome, int idade, double salario, int grauInstrucao)
            : base(nome, idade, salario, grauInstrucao)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
            GrauInstrucao = grauInstrucao;
        }

        public override double Bonificacao()
        {
            var bonificacao = Salario + (500.00 * GrauInstrucao * 3);
            Salario += bonificacao;
            return bonificacao;
        }

        public override string ToString()
        {
            return "Nome do Supervisor: " + this.Nome + " idade: " + this.Idade + "\nGrau de instrução: " + this.GrauInstrucao + " Salario: " + this.Salario + "R$";
        }
    }
}
