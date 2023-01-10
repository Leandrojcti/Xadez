using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro {
    class Tabuleiro {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] pecas;  //Declarado uma matriz do tipo Peca

        public Tabuleiro(int linhas, int colunas) {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[linhas, colunas]; //ja instancia e seta linhas e colunas com argumento
        }

        public Peca peca(int linha, int coluna) {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos) {
            pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
    }
}
