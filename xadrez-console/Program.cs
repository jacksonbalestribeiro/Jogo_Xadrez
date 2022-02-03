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
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 5));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 0));

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 7));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(6, 5));

                Tela.imprimirTabuleiro(tab);
            }catch(TabuleiroExeption e)
            {
                Console.WriteLine(e.Message.ToString());
            }

            Console.WriteLine("");
        }
    }
}
