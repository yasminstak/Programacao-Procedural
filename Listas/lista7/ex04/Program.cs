using System;

class Program
{
    static void Main()
    {
        int[] pesosVagoes = new int[12];

        PreencherVetor(pesosVagoes);

        VerificarExcessoPeso(pesosVagoes);
    }

    static void PreencherVetor(int[] vetor)
    {
        Console.WriteLine("Digite o peso de cada vagão:");

        for (int vagao = 0; vagao < vetor.Length; vagao++)
        {
            Console.Write("● ");
            vetor[vagao] = int.Parse(Console.ReadLine());
        }
    }

    static void VerificarExcessoPeso(int[] vetor)
    {
        for (int ultrapassou = 0; ultrapassou < vetor.Length; ultrapassou++)
        {
            if (vetor[ultrapassou] > 50)
            {
                Console.WriteLine((ultrapassou + 1) + "° vagao ultrapassou o limite de peso");
            }
        }
    }
}
