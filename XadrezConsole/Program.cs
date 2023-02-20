using System;
using Tabuleiro;
using Xadrez;


namespace XadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleir tab = new Tabuleir(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tab);

        }
    }
}