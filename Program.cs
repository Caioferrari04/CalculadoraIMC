using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome: ");
            string nomeUsuario = Console.ReadLine();

            Console.WriteLine("Entre com a sua altura: ");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Entre com o seu peso: ");
            float peso = Convert.ToSingle(Console.ReadLine());

            float imc = peso / (altura*altura);

            Console.WriteLine($"{nomeUsuario}, seu IMC é: {imc}");

            float pesoIdeal = 21*(altura*altura);
            double pesoNecessario = pesoIdeal > peso ? pesoIdeal - peso : peso - pesoIdeal;
            
            pesoNecessario = Math.Round(pesoNecessario);

            if(imc <= 0)
            {
                Console.WriteLine("Valores inválidos!");
            }
            else if(imc <= 18.5)
            {
                Console.WriteLine($"Status: Abaixo do peso; Você precisa ganhar {pesoNecessario}kg para ter o peso normal.");
            }
            else if(imc <= 24.9)
            {
                Console.WriteLine("Status: Peso normal;");
            }
            else if(imc <= 29.9)
            {
                Console.WriteLine($"Status: Sobrepeso; Você precisa perder {pesoNecessario}kg para ter o peso normal.");
            }
            else if(imc <= 34.9)
            {
                Console.WriteLine($"Status: Obesidade Grau I; Você precisa perder {pesoNecessario}kg para ter o peso normal.");
            }
            else if(imc <= 39.9)
            {
                Console.WriteLine($"Status: Obesidade Grau II; Você precisa perder {pesoNecessario}kg para ter o peso normal.");
            }
            else if(imc >= 40)
            {
                Console.WriteLine($"Status: Obesidade Grau III ou Mórbida; Você precisa perder {pesoNecessario}kg para ter o peso normal.");
            }
        }
    }   
}
