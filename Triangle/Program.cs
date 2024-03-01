// See https://aka.ms/new-console-template for more information
using System; 

namespace Triangulo
    {
        class Program
        {

            static void Main (string[] args)
            {
            // Entrada de dados
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome);

            Console.WriteLine("Para começar, digite o valor dos três lados dos triângulos:");
            Console.WriteLine("Qual o valor do primeiro lado?");
            int lado1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do segundo lado?");
            int lado2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor do terceiro lado?");
            int lado3 = int.Parse(Console.ReadLine());


            // Equilátero = lado1, lado2 e lado3 iguais
            if(lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Seu triangulo é equilatero");
            }
            // Escaleno = lado1, lado2 e lado3 diferentes
            else if (lado1 != lado2 && lado2 != lado3 && lado3 == lado1)
            {
                Console.WriteLine("Seu triangulo é escaleno");
            }
            // Isósceles = Lado1 e lado2 iguais, lado2 e lado3 iguais ou lado3 e lado1 iguais
            else
            {
                Console.WriteLine("Seu triangulo é isósceles");
            }
            }
        }
    }