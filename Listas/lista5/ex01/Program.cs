using System;

class Program
{
    static void Main()
    {
        for(int progressiva = 0, regressiva = 200; progressiva <= 100; progressiva += 2, regressiva -= 4)
        {
            System.Console.WriteLine($"{progressiva} - {regressiva}");
        }
    }
}
