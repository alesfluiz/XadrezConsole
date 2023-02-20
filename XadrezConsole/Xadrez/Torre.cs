using Tabuleiro;

namespace Xadrez
{
    internal class Torre : Peca
    {
        public Torre(Tabuleir tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}
