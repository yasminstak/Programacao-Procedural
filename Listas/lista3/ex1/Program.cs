using System;

class Program
{
    static void Main (string[] args)
    {
        const int NUMERO_DE_HABITANTES = 20;
        double mediaSalarial  = 3;
        double maiorSalario = 0;
        double somatorioSalarial = 0;
        int somatoriaFilhos = 0;

        for (int contador = 1; contador <= NUMERO_DE_HABITANTES; contador++)
         {
            System.Console.WriteLine("Digite o seu salario: ");
            double salario = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a quantidade de filhos: ");
            int numeroDeFilhos = int.Parse(Console.ReadLine());

            somatorioSalarial = somatorioSalarial + salario;
            somatoriaFilhos = somatoriaFilhos + numeroDeFilhos;
            if (maiorSalario > salario)
            {
                salario = maiorSalario;
            } 
        
         }
            mediaSalarial = somatorioSalarial / NUMERO_DE_HABITANTES;
            mediaFilhos = somatoriaFilhos / NUMERO_DE_HABITANTES;
            System.Console.WriteLine("A media salarial é: " + mediaSalarial);
            System.Console.WriteLine("O maior salario é: " + maiorSalario);
            System.Console.WriteLine("A media de filhos é " + mediaFilhos);

























    }
}

