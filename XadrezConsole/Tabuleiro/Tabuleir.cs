using System;

namespace Tabuleiro
{
    internal class Tabuleir
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleir(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[Linhas, Colunas];
        }
        public Peca Pecai(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

    }
}
