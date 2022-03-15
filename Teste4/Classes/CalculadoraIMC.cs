namespace Teste4.Classes
{
    public class CalculadoraIMC
    {
        public CalculadoraIMC(string nome, double altura, double peso)
        {
            Nome = nome;
            Altura = altura;
            Peso = peso;
        }
        public string Nome { get; private set; }
        public double Altura { get; private set; }
        public double Peso { get; private set; }

        public string Calcular()
        {
            var imc = Peso / (Altura * Altura);
            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            if (imc >= 18.5 && imc <= 24.9)
            {
                return "Peso normal";
            }
            if (imc >= 25 && imc <= 29.9)
            {
                return "Sobrepeso";
            }
            if (imc >= 30 && imc <= 34.9)
            {
                return "Obesidade Grau I";
            }
            if (imc >= 35 && imc <= 39.9)
            {
                return "Obesidade Grau II";
            }
            else
            {
                return "Obesidade Grau III";
            }

        }

        public override string ToString()
        {
            return "Nome: " + this.Nome + " Altura: " + this.Altura + "m" + " Peso: " + this.Peso + "kg";
        }
    }
}
