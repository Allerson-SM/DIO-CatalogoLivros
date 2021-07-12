using System;

namespace CatalogoLivros.Exceptions
{
    public class LivroJaCadastradoException : Exception
    {
        public LivroJaCadastradoException()
            : base("Este livro já está cadastrado!")
        { }
    }
}
