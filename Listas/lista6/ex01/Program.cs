using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[10];

        for (int nomes = 0; nomes < 10; nomes++)
        {
            Console.Write("Digite um nome: ");
            nomes[nomes] = Console.ReadLine();
        }

        Console.Write("Digite o nome a ser buscado: ");
        string nomeBusca = Console.ReadLine();

        bool encontrado = false;
        {
            if (nome == nomeBusca)
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
        {
            Console.WriteLine("ACHEI");
        }
        else
        {
            Console.WriteLine("NAO ACHEI");
        }
    }
}