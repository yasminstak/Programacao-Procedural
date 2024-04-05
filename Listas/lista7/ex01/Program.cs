using System;

class Program
{
    static void Main()
    {
        int numero = int.Parse(Console.ReadLine()); 

        bool resultado = VerificarPar(numero);

        Console.WriteLine(resultado);
    }

    static bool VerificarPar(int numero)
    {
        if (numero % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

