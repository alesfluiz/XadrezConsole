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
            this.Linhas = linhas;
            this.Colunas = colunas;
            Pecas = new Peca[Linhas, Colunas];
        }
    }
}
