using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("digite a nota 1");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("digite a nota 2");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("digite a nota 3");
        double nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("digite a nota 4");
        double nota4 = double.Parse(Console.ReadLine());

        double resultado = (nota1 + nota2 + nota3 + nota4) / 4;
        if (resultado >= 5.0)
        {
            Console.WriteLine("aluno aprovado");
        }
        else if (resultado < 5.0 && resultado >= 3.0)
        {
            Console.WriteLine("aluno em recuperacao");
        }
        else
        {
            Console.WriteLine("aluno reprovado");






















        }
    }
}

