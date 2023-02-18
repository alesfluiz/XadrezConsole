using Tabuleiro;

namespace XadrezConsole
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(Tabuleir tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Pecai(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write($"{tab.Pecai(i, j)} ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
