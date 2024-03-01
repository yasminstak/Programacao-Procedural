using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("digite seu nome de usuario: ");
        string NomeUsuario = Console.ReadLine();

        Console.WriteLine("digite sua senha:");
        string senha = Console.ReadLine();

        if (NomeUsuario == "admin" && senha == "12345")
        {
            Console.WriteLine("login realizado com sucesso!");
        }
        else
        {
            Console.WriteLine("credenciais invalidas!");
        }




    }
  }
