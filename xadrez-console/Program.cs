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
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 9));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));

                Tela.imprimirTabuleiro(tab);
            }catch(TabuleiroExeption e)
            {
                Console.WriteLine(e.Message.ToString());
            }

            Console.WriteLine("");
        }
    }
}
