using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace Xadrez {
    class Tela {
        public static void imprimirTabuleiro(Tabuleiro tab) {
            for (int i_L = 0; i_L < tab.Linhas; i_L++) {
                for (int j_C = 0; j_C < tab.Colunas; j_C++) {
                    if (tab.peca(i_L, j_C) ==null) {
                        Console.Write("- ");
                    } else {
                        Console.Write(tab.peca(i_L, j_C) + "");
                    }
                }
                Console.WriteLine();





            }
        }
    }
}
