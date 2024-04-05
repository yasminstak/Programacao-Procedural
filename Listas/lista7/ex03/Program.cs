using System;

class Program
{
    static void Main()
    {
        int idadeNadador = int.Parse(Console.ReadLine());

        string categoria = ClassificarNadador(idadeNadador);

        Console.WriteLine("Categoria do nadador: " + categoria);
    }

    static string ClassificarNadador(int idade)
    {
        if (idade < 12)
        {
            return "Infantil";
        }
        else if (idade >= 12 && idade <= 14)
        {
            return "Juvenil A";
        }
        else if (idade >= 15 && idade <= 17)
        {
            return "Juvenil B";
        }
        else
        {
            return "Adulto";
        }
    }
}
