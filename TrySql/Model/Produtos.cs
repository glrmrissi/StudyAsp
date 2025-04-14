using System.Text.Json.Serialization;

namespace TrySql.Model
{
    public class Produtos
    {
        public int ID { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public string? ImagemUrl { get; set; }
        public DateTime DataCompra { get; set; } = DateTime.UtcNow;
        public int Estoque { get; set; }
        public int CategoriaId { get; set; }

        [JsonIgnore]
        public Categoria Categoria { get; set; }
    }
}
