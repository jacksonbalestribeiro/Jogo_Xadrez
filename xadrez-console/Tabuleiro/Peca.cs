namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimento { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, int qtdMovimento, Tabuleiro tab)
        {
            this.Posicao = posicao;
            this.Cor = cor;
            this.QtdMovimento = qtdMovimento;
            this.Tab = tab;
            this.QtdMovimento = 0;
        }
    }
}
