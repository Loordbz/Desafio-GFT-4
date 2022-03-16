# Desafio-GFT-4

PROGRAMA STARTER 
TESTE TÉCNICO 
PROGRAMAÇÃO ORIENTADA À OBJETOS DATA: 15/03/2022

1. Considerando os conceitos de Orientação a Objetos, crie uma superclasse Colaborador com os seguintes atributos (nome, idade, salario e grauInstrucao) e mais três classes  (Gerente, Supervisor e Vendedor) que deverão ser herdeiras da classe Colaborador.  O atributo grauInstrucao deverá ser do tipo inteiro, podendo ser um valor que vai de 1  até 5. Na classe Colaborador deve existir um método de nome bonificação que retorna  o salário, nas classes filhas deve existir o mesmo método bonificação porem com as  seguintes regras (3 pontos): 
• Para Gerente, o método bonificação deve retornar o salário + 1000.00 x grauInstrucao  x 2; 
• Para Supervisor, o método bonificação deve retornar o salário + 500.00 x  grauInstrucao x 3; 
• Para Vendedor, o método bonificação deve retornar o salário + 300.00 x grauInstrucao  x 4; 
Por fim, criar uma classe principal que instancie objetos de Gerente, Supervisor e  Vendedor e adicione no mínimo um valor para cada atributo e imprima cada funcionário  (Gerente, Supervisor e Vendedor) com suas devidas bonificações 

2. Crie um programa que leia um valor inteiro (este número tem que conter 4 dígitos). Como saída o programa deverá mostrar quantos números “ímpares” existem no valor  digitado (2 pontos). 
Exemplo.: Digamos que a entrada foi 3257. A resposta será 3 
Regras: 
a) A entrada deve estar entre 350 e 8750

b) Se o usuário digitar 2 dígitos ou menos, o Programa avisa que tem que conter 3  dígitos e continuar a programação até a resposta final. 

3. Crie uma superclasse abstrata de nome Conta com os seguintes atributos (numero,  titular e saldo) e mais duas classes (ContaCorrente e ContaPoupanca). Na classe  Conta deve existir um método de nome rendimento que retorna o rendimento mensal  da conta. Nas demais classes deve existir o mesmo método rendimento, porém com as  seguintes regras (3 pontos): 
• Caso seja conta corrente, o método rendimento deve retornar o saldo * 0.05.  Além disso uma conta corrente possui um valor mensal de manutenção. Então  subtraia 0,75 do saldo total da conta. 
• Caso seja conta poupança, o método rendimento deve retornar o saldo * 0.07; 
Por fim, criar uma classe principal que instancie objetos de ContaCorrente e  ContaPoupanca, adicione no mínimo um valor para cada atributo e imprima cada  conta (ContaCorrente e ContaPoupanca) com seus devidos rendimentos. 
 Obs: Encapsular atributos das classes. 
 
4. Crie um programa que leia altura, peso e nome de uma pessoa. Com base nesses dados  o programa deverá calcular qual é o índice de massa corporal dessa pessoa. Como  resultado o programa deverá apresentar o nome da pessoa, seu peso, altura, seu índice  de massa corporal, e em que faixa da tabela abaixo essa pessoa se enquadra (2 pontos). 

Obs: IMC = PESO / (ALTURA²)

