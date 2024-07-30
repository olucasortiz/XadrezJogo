using System.Xml;
using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna {  get; set; }
        public int linha {  get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao()//retorna uma nova posicoa combase na forma que o xadrez e feito, ao inves de 0,0 vai ser 8A, em coordenadas  z
        {
            return new Posicao(8-linha, coluna - 'a');
        }

        public override string ToString()
        {
            return " " + coluna + linha;
        }
    }
}
