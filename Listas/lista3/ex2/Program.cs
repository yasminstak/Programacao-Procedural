using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int contador = 1;
    double somatorioValores = 0;
    double totalItensComprados = 0;

    Console.WriteLine("Digite a quantidade de itens que voce comprou: ");
    int itensComprados = int.Parse(Console.ReadLine());

    while (contador <= itensComprados)
    {
      Console.WriteLine("Digite o valor do " + contador + " º item: R$");
      double valorItem = double.Parse(Console.ReadLine());
      totalItensComprados = totalItensComprados + valorItem;
      contador ++;
    
    }
    if (totalItensComprados >= 150)
    {
        System.Console.WriteLine("parabens! voce ganhou frete gratis em sua compra de valor: " + 
        Math.Round(totalItensComprados));
    }
    else
    {
        System.Console.WriteLine("Que pena! sua compra nao possui frete gratis");
    }
      
    }
  }
