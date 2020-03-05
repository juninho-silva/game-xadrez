using System;
using Xadrez.Plataforma;

namespace Xadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for(int l = 0; l < tabuleiro.Linhas; l++)
            {
                for (int c = 0; c < tabuleiro.Colunas; c++)
                {
                    var peca = tabuleiro.Peca(l, c);

                    if(peca == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(peca + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
