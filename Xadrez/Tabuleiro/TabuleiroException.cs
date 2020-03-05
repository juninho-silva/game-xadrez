using System;

namespace Xadrez.Exception
{
    public class TabuleiroException : System.Exception
    {
        public TabuleiroException(string mensagemErro)
        {
            Console.Write(mensagemErro);
        }
    }
}
