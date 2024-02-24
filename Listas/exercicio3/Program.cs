using System;

class Program 
{
    public static void Main(string[] args)
    {
  
       Console.Write("digite a quantidade de centavos: ");
       int centavos = Convert.ToInt32(Console.ReadLine());
  
       int reais = centavos / 100;
       int centavosRestantes = centavos % 100;

     Console.WriteLine("O total em dinheiro eh " + reais + " real (is) e " +
centavosRestantes + " centavo (s) ");
      }
}