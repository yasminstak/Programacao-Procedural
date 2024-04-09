using System;

class Program
{
    static void Main (string[] args)
    {
        System.Console.WriteLine("Digite sua altura");
        double altura = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite seu peso");
        double peso = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);
        if (imc < 18.5)
        {
            System.Console.WriteLine("magreza");
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            System.Console.WriteLine("normal");
        }
        else if (imc >= 25.0 && imc <= 29.0)
        {
            System.Console.WriteLine("sobrepeso");
        }
        else if (imc >= 30.0 && imc <= 39.9)
        {
            System.Console.WriteLine("Obesidade");
        }
        else
        {
            System.Console.WriteLine("obesidade grave");
        }


    }
}
