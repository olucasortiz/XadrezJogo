using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colocarPeca(new Torre(tab, Cor.Azul), new Posicao(1, 0));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 0));
                tab.colocarPeca(new Rei(tab, Cor.Vermelha), new Posicao(3, 0));
                tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(1, 4));

               // PosicaoXadrez pos = new PosicaoXadrez('a',1);
              //  Console.WriteLine(pos.toPosicao());
                Tela.imprimirTabuleiro(tab);
                Console.ReadLine();
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}

