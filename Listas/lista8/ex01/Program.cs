using System;

struct Pizza
{
    public int id;
    public string sabor;
    public double preco;
}

class Program
{
    static void Main()
    {
        Pizza minhaPizza;
        
        Console.WriteLine("Digite o ID da pizza:");
        minhaPizza.id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o sabor da pizza:");
        minhaPizza.sabor = Console.ReadLine();

        Console.WriteLine("Digite o preço da pizza:");
        minhaPizza.preco = 36.99;

        Console.WriteLine("\nDados da pizza:");
        Console.WriteLine("ID: " + minhaPizza.id);
        Console.WriteLine("Sabor: " + minhaPizza.sabor);
        Console.WriteLine("Preço: " + minhaPizza.preco);
    }
}


