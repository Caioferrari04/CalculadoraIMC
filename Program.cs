using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Individuo individuo = new Individuo();

            Console.WriteLine("Entre com o seu nome: ");
            individuo.Nome = Console.ReadLine();

            Console.WriteLine("Entre com a sua altura: ");
            individuo.Altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Entre com o seu peso: ");
            individuo.Peso = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"{individuo.Nome}, seu IMC é: {individuo.IMC}");
            
            Console.WriteLine(individuo.Status());
            
        }
    }   
}
