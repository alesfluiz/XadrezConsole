using Tabuleiro;

namespace Xadrez
{
    internal class Rei : Peca
    {
       public Rei(Tabuleir tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}
