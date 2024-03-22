using System;

class Program
{
    static void Main()
    {
        for (int multiplicador = 10; multiplicador >= 1; multiplicador--)
        {
            for (int multiplicando = 0; multiplicando <= 10; multiplicando++)
            {
                Console.WriteLine($"{multiplicador} x {multiplicando} = {multiplicador * multiplicando}");
            }
            Console.WriteLine();
        }
    }
}
