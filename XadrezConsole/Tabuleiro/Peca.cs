

namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleir Tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleir tab, Cor cor)
        {
            this.Posicao = posicao;
            this.Cor = cor;
            this.QteMovimentos = 0;
            this.Tab = tab;
        }
    }
}
