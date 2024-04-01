using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];
        
        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write($"Digite o valor para a posição [{linha},{coluna}]: ");
                matriz[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("A matriz digitada é:");
        for (int matrizDigitada = 0; matrizDigitada< 3; matrizDigitada++)
        {
            for (int matriz = 0; matriz < 3; matriz++)
            {
                Console.Write(matriz[matrizDigitada, matriz] + "\t");
            }
            Console.WriteLine();
        }

        int somaDiagonalPrincipal = 0;
        for (int diagonal = 0; diagonal < 3; diagonal++)
        {
            somaDiagonalPrincipal += matriz[diagonal, diagonal];
        }

        Console.WriteLine($"A soma dos valores da diagonal principal é: {somaDiagonalPrincipal}");
    }
}
