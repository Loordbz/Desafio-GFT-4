namespace Teste1.Classes
{
    public class Gerente : Colaborador
    {
        public Gerente(string nome, int idade, double salario, int grauInstrucao)
            : base(nome, idade, salario, grauInstrucao)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
            GrauInstrucao = grauInstrucao;
        }

        public override double Bonificacao()
        {
            var bonificacao = Salario + (1000.00 * GrauInstrucao * 2);
            Salario += bonificacao;
            return bonificacao;
        }

        public override string ToString()
        {
            return "Nome do Gerente: " + this.Nome + " idade: " + this.Idade + "\nGrau de instrução: " + this.GrauInstrucao + " Salario: " + this.Salario + "R$";
        }
    }
}
