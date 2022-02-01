using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for(int i = 0; i < tab.Linhas; i++)
            {
                for(int ii = 0;ii< tab.Colunas; ii++)
                {
                    if (tab.peca(i,ii) is null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, ii) + " ");
                    }
                    
                }
                Console.WriteLine(" ");
            }

        }
    }
}
