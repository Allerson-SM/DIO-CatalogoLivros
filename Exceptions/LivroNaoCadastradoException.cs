using System;

namespace CatalogoLivros.Exceptions
{
    public class LivroNaoCadastradoException: Exception
    {
        public LivroNaoCadastradoException()
            :base("Este livro não está cadastrado!")
        {}
    }
}
