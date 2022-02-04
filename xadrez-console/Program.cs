using System;
using xadrez;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   

                PartidaDeXadrez partida = new PartidaDeXadrez();
                Tela.imprimirTabuleiro(partida.tab);

            }catch(TabuleiroExeption e)
            {
                Console.WriteLine(e.Message.ToString());
            }

            Console.WriteLine("");
        }
    }
}
