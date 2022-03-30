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
            
            
        }
    }   
}
