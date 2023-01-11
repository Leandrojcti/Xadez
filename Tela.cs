using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace Xadrez {
    class Tela {
        public static void imprimirTabuleiro(Tabuleiro tab) {
            for (int i_L = 0; i_L < tab.Linhas; i_L++) {
                Console.Write(8 - i_L + " ");
                for (int j_C = 0; j_C < tab.Colunas; j_C++) {
                    if (tab.peca(i_L, j_C) ==null) {
                        Console.Write("- ");
                    } else {
                        ImprimirPeça(tab.peca(i_L, j_C));
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine( "  a b c d e f g h");
        }
        public static void ImprimirPeça(Peca peca) {
            if (peca.Cor == Cor.Branca) {
                Console.Write(peca);
            } else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

    }
}





