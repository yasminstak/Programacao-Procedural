using System;

struct Produto
{
    public int id;
    public string nome;
    public double preco;
    public bool disponivelEmEstoque;
}

class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[4];

        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine("Digite o ID do produto:");
            produtos[i].id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto:");
            produtos[i].nome = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            produtos[i].preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O produto está disponível em estoque? (true/false):");
            produtos[i].disponivelEmEstoque = Convert.ToBoolean(Console.ReadLine());

            
        }

        Console.WriteLine("\nProdutos disponíveis em estoque:");
        for (int i = 0; i < produtos.Length; i++)
        {
            if (produtos[i].disponivelEmEstoque)
            {
                Console.WriteLine(produtos[i].nome);
                Console.WriteLine(produtos[i].preco.ToString("C2"));
            }
        }
    }
}
