using System;

namespace CatalogoLivros.Entities
{
    public class Livro
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public double Preco { get; set; }
    }
}
