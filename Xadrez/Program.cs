﻿using System;
using Xadrez.Pecas;
using Xadrez.Exception;
using Xadrez.Plataforma;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);
                
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preto), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preto), new Posicao(1, 3));
                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preto), new Posicao(2, 4));
                
                Tela.ImprimirTabuleiro(tabuleiro);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }   
}
