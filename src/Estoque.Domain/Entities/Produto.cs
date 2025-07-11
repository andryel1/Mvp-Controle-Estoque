namespace Estoque.Domain.Entities
{
    public class Produto : EntityBase
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal Peso { get; set; }
        public string Dimensoes { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public int UnidadeMedidaId { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }
        public int FornecedorId { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual ICollection<Estoque> Estoques { get; set; } = [];
    }
}