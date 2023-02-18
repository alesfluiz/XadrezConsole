

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
            Posicao = posicao;
            Cor = cor;
            QteMovimentos = 0;
            Tab = tab;
        }
    }
}
