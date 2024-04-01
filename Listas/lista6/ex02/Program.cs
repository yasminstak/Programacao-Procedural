using System;

namespace ExercicioVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];

            for (int nome = 0; nome < 10; nome++)
            {
                Console.Write("Digite um nome: ");
                nomes[nome] = Console.ReadLine();
            }

            Console.WriteLine("Nomes nos índices pares, do último para o primeiro:");

            for (int indices = 8; indices >= 0; indices -= 2)
            {
                Console.WriteLine(nomes[indices]);
            }
        }
    }
}

