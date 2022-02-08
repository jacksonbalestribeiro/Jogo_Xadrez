namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimento { get; protected set; }
        public Tabuleiro Tab { get; protected set; }
        public Peca(Tabuleiro tab, Cor cor)
        {
            this.Cor = cor;
            this.Tab = tab;
            this.Posicao = null;
            this.QtdMovimento = 0;
        }
        public void incrementarQtdMov()
        {
            QtdMovimento++;
        }

        public bool existeMovimentoPossivel()
        {
            bool[,] mat = movimentosPossiveis();
            for(int i = 0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j < Tab.Colunas; j++ )
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        public abstract bool[,] movimentosPossiveis();

    }
}
