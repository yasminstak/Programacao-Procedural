using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			 int somaImpares = 0;

        while (true)
        {
            
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                break;
            }

            if (numero % 2 != 0)
            {
                somaImpares += numero;
            }
        }

        Console.WriteLine($"O somatório de ímpares é: {somaImpares}");
		}
	}
}