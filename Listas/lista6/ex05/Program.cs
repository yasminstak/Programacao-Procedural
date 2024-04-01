using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[10];
        int indice = 0;

        while (indice < 10)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 10 && numero <= 50)
            {
                vetor[indice] = numero;
                indice++;
            }
            else
            {
                Console.WriteLine("O número digitado não atende aos critérios. Tente novamente.");
            }
        }

        Console.WriteLine("Os números armazenados no vetor são:");
        {
            foreach (int numero in vetor)
            Console.Write(numero + " ");
        }
    }
}
