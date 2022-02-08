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

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.WriteLine("Turno: " + partida.Turno.ToString());
                    Console.WriteLine("Aguardando jogada: " + partida.JogadorAtual.ToString());

                    Console.WriteLine("");
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] possiveisPosicoes = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, possiveisPosicoes);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.realizaJogada(origem, destino);

                }
                

            }catch(TabuleiroExeption e)
            {
                Console.WriteLine(e.Message.ToString());
            }

            Console.WriteLine("");
        }
    }
}
