using System;

class Program
{
    static void Main()
    {
        int numero1 = int.Parse(Console.ReadLine());
        int numero2 = int.Parse(Console.ReadLine());
        int numero3 = int.Parse(Console.ReadLine());

        int maiorNumero = EncontrarMaior(numero1, numero2, numero3);

        Console.WriteLine("O maior número é: " + maiorNumero);
    }

    static int EncontrarMaior(int num1, int num2, int num3)
    {
        int maior = num1;

        if (num2 > maior)
        {
            maior = num2;
        }

        if (num3 > maior)
        {
            maior = num3;
        }

        return maior;
    }
}
