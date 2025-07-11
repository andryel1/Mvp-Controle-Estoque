namespace Estoque.Domain.Entities
{
    public class Categoria : EntityBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Produtos> Produtos { get; set; } = [];
    }
}