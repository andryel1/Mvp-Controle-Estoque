namespace Estoque.Domain.Entities
{
    public class UnidadeMedida : EntityBase
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; } = [];
    }
}