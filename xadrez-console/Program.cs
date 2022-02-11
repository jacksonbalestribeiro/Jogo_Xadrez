using System;
using xadrez;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            PartidaDeXadrez partida = new PartidaDeXadrez();
            Tela.imprimirTabuleiro(partida.tab);

            while (!partida.terminada)
            {
                try
                {
                    Console.Clear();
                    Tela.imprimirPartida(partida);

                    Console.WriteLine("");
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosicaoOrigem(origem);

                    bool[,] possiveisPosicoes = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, possiveisPosicoes);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosicaoDestino(origem, destino);

                    partida.realizaJogada(origem, destino);

                }
                catch (TabuleiroExeption e)
                {
                    Console.WriteLine(e.Message.ToString());
                    Console.ReadLine();
                }

            }
            Console.WriteLine("");
        }
    }
}
