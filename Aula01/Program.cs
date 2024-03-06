
//altere o programa para calcular o imc de uma pessoa
// imc = peso / altura * altura
using Aula01;
using System.Globalization;

bool entrada = true;
do
{
    try
    {
        Console.WriteLine("Informe o peso atual: ");
        int peso = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a altura atual: ");
        float altura = float.Parse(Console.ReadLine());
        CalculaIMC calculaIMC = new CalculaIMC(); //instanciando
        //string resultado = calculaIMC.Calcular(peso, altura);
        Console.WriteLine(calculaIMC.Calcular(peso, altura));

        //Crie uma classe chamada calculadora q possua um metodo que
        //some dois numeros inteiros e retorne o resultado dessa soma.
        // o nome do metodo = Soma; exibir os numeros informdos e o valor da soma;
        Console.WriteLine("Informe um número inteiro: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe outro número inteiro: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        //var calculadora = new Calculadora(); //instanciar assim nao é necessario usando static
        Console.WriteLine($"A soma dos números {num1} + {num2} é {Calculadora.Soma(num1, num2)}");
        
        entrada = false;
    }
    catch (FormatException e)
    {
        Console.WriteLine("O peso deve ser um número inteiro e a altura em numero decimal");
    }
} while (entrada);



