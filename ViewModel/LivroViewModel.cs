using System;

namespace CatalogoLivros.ViewModel
{
    public class LivroViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public double Preco { get; set; }
    }
}
