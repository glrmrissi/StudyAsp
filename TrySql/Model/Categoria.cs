namespace TrySql.Model
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string? CategoriaNome { get; set; }
        public string? CategoriaDescricao { get; set; }

        public ICollection<Produtos>? Produtos { get; set; }
    }
}
