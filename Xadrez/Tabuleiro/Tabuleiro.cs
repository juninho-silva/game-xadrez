using Xadrez.Exception;

namespace Xadrez.Plataforma
{
    public class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            this.pecas = new Peca[linhas, colunas];
        }

        public Peca Peca(int linha, int coluna)
        {
            return this.pecas[linha, coluna];
        }

        public Peca Peca(Posicao posicao)
        {
            return this.pecas[posicao.Linha, posicao.Coluna];
        }

        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            if(this.ExistePeca(posicao))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        private bool PosicaoValida(Posicao posicao)
        {
            if (posicao.Linha < 0 
                || posicao.Linha >= Linhas
                || posicao.Coluna < 0
                || posicao.Coluna >= Colunas)
            {
                return false;
            } return true;     
        }

        public bool ExistePeca(Posicao posicao)
        {
            this.ValidarPosicao(posicao);
            return Peca(posicao) != null;
        }

        private void ValidarPosicao(Posicao posicao)
        {
            if(this.PosicaoValida(posicao))
            {
                throw new TabuleiroException("Posição inválida"); 
            }
        }
    }
}
