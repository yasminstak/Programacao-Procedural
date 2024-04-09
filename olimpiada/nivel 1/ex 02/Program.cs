using System;

class Program
{
    public static void Main (string[] args)
    {
        Console.WriteLine ("Digite a palavra: ");
        string palavra = Console.ReadLine ();

        string eco = $"{palavra}...{palavra}...{palavra}...";

        System.Console.WriteLine(eco);
 
    }
}
