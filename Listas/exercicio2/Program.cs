using System;

class Program
{
  public static void Main (string[] args) 
  {
    
   double baseTriangulo = 2.2;
   double alturaTriangulo = 6.3;
    
   double area = (baseTriangulo * alturaTriangulo)/2;

   bool resultado = area > 20;
    
    Console.WriteLine("a area do triangulo eh maior que 20?");
    Console.WriteLine (resultado);

    Console.WriteLine(area);
    

  }
}
