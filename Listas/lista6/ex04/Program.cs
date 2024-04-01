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
                Console.Write($"Digite o valor para a posição [{i},{j}]: ");
                int numero = int.Parse(Console.ReadLine());
                if (linha + coluna == 2) 
                {
                    matriz[linha, coluna] = numero * 2;
                }
                else
                {
                    matriz[linha, coluna] = numero;
                }
            }
        }

        Console.WriteLine("A matriz digitada é:");
        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write(matriz[linha, coluna] + "\t");
            }
            Console.WriteLine();
        }
    }
}
