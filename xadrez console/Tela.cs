using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.WriteLine(8-i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                        Console.Write(" -");
                    else
                    {
                        Console.Write(tab.peca(i, j) + " ");
                        Console.Write("");
                    }
                        
                }
                Console.WriteLine(); // Adiciona uma nova linha após imprimir cada linha do tabuleiro
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branca)
                Console.WriteLine(peca);
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;  
            }
        }
    }
}
