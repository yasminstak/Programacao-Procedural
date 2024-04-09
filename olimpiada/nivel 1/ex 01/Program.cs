using System;

class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Oi, Digite seu nome completo: ");
        string nomeCompleto = Console.ReadLine();

        string[] partesDoNome = nomeCompleto.Split();
    

        if (partesDoNome.Length <= 2 )
        {
            string cumprimento = "ola " + partesDoNome[1] + " " + partesDoNome[0] + "!";

            System.Console.WriteLine(cumprimento);

        }

        
    }
}
