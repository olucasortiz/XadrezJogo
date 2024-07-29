using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public int qtdMovimento { get; protected set; }
        public Cor cor { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.qtdMovimento = 0;
            this.cor = cor;
            this.tab = tab;
        }
    }
}
