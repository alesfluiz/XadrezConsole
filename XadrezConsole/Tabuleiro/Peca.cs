

namespace Tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleir Tab { get; protected set; }

        public Peca(Tabuleir tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QteMovimentos = 0;
            
        }
        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }
        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for(int i=0; i < Tab.Linhas; i++)
            {
                for(int j=0; j< Tab.Colunas; j++)
                {
                    if (mat[1, j])
                    {
                        return true;
                    }
                    
                }
            }
            return false;
        }

        public abstract bool[,] MovimentosPossiveis();
        
    }
}
