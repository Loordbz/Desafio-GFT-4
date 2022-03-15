namespace Teste1.Classes
{
    public class Vendedor : Colaborador
    {
        public Vendedor(string nome, int idade, double salario, int grauInstrucao)
            : base(nome, idade, salario, grauInstrucao)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
            GrauInstrucao = grauInstrucao;
        }

        public override double Bonificacao()
        {
            var bonificacao = Salario + (300.00 * GrauInstrucao * 4);
            Salario += bonificacao;
            return bonificacao;
        }

        public override string ToString()
        {
            return "Nome do Vendedor: " + this.Nome + " idade: " + this.Idade + "\nGrau de instrução: " + this.GrauInstrucao + " Salario: " + this.Salario + "R$";
        }
    }
}
