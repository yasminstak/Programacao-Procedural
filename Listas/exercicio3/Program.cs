using System;

class Program 
{
    public static void Main(string[] args)
    {
  
       Console.WriteLine("digite a quantidade de centavos: ");
       int centavos = int.Parse(Console.ReadLine());
  
       int reais = centavos / 100;
       int centavosRestantes = centavos % 100;

       Console.WriteLine("O total em dinheiro eh " + reais + " real (is) e " +
       centavosRestantes + " centavo (s) ");
      }
}