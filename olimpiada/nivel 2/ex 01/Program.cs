using System;
using System.Xml;

class Program
{
    static void Main (string[] args)
    {
        System.Console.WriteLine("Digite o tamanho do traingulo: ");
        int tamanho = int.Parse(Console.ReadLine());

        for (int linha = tamanho ; linha >= 1; linha--)
        {
            for (int coluna = 1; coluna <= tamanho - linha; coluna++)
            {
                System.Console.WriteLine();
                for (int i = 1; i < linha; i++)
                {
                    System.Console.WriteLine("*");
                }
            }
        }
        System.Console.WriteLine();
    }
}
