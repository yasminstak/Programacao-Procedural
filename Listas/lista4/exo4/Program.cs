using System;

class Program
{
    static void Main (string[] args)
    {

        Tabuleiro.InicializaTabuleiro();

        for (int linha = 0; linha < 8; linha++)
        {

         for (int coluna = 0; coluna < 8; coluna++)
         {
            if (linha == 7)
            {
            Tabuleiro.Adicionar(linha , coluna, "s");
            }
            if (coluna == 7)
            {
             Tabuleiro.Adicionar(linha , coluna, "s");   
            }
           
            if (linha == 0)
            {
            Tabuleiro.Adicionar(linha , coluna, "s");
            }
            if (coluna == 0)
            {
             Tabuleiro.Adicionar(linha , coluna, "s");   
            }


         }   

            
        }

        Tabuleiro.ImprimeTabuleiro();


    }




}

