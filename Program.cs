using System;
using tabuleiro;
using xadrez;

namespace Xadrez {
    class Program {
        static void Main(string[] args) {
            try {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0,2));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 3));
                
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 5));

                Tela.imprimirTabuleiro(tab);

            } catch(tabuleiroException e) {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
        }
    }
}
