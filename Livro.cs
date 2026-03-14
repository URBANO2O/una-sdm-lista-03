using System;

namespace UnaSdmLista03
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Edicao { get; set; }
        public int AnoPublicacao { get; set; }
        public string Editora { get; set; }
        public int NumeroPaginas { get; set; }
        public string Categoria { get; set; }
        public string Isbn { get; set; }
        public string Idioma { get; set; }
        public bool Disponivel { get; set; }
    }
}