using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(6,6);
            tab.colocarPeca(new Torre(tab,Cor.Azul),new Posicao(1,0));
            tab.colocarPeca( new Torre(tab,Cor.Branca), new Posicao(2,0));
            tab.colocarPeca(new Rei(tab,Cor.Vermelha) , new Posicao(3,0));
            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}

