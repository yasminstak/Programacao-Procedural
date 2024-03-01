using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("digite o nome da criança (filomena ou joselito)");
        string nomeDaCrianca = Console.ReadLine();

        if (nomeDaCrianca == "filomena")
        {
            Console.WriteLine("Rotina de filomena: ");
            Console.WriteLine("1. Escola das 07h as 12h");
            Console.WriteLine("2. Almoço das 12h às 13h");
            Console.WriteLine("3. Futebol das 14h às 16h");
            Console.WriteLine("4. Dever de casa das 16h às 18h");

        }
        else if (nomeDaCrianca == "joselito") 
        {
            Console.WriteLine("Rotina de Joselito:");
            Console.WriteLine("1. Escola das 07h às 12h30");
            Console.WriteLine("2. Almoço das 13h às 14h");
            Console.WriteLine("3. Natação das 14h às 16h");
            Console.WriteLine("4. Reforço escolar das 16h às 19h");

        }
        else 
        {
            Console.WriteLine("Nome de criança inválido");
        }
      }
  }
