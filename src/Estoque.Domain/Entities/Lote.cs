namespace Estoque.Domain.Entities
{
    public class Lote
    {
           public class Lote
    {
        public int Id { get; set; }
        public string NumeroLote { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public int Quantidade { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public int EstoqueId { get; set; }
        public virtual Estoque Estoque { get; set; }
        public bool Vencido => DateTime.Now > DataValidade;
        public bool ProximoVencimento => (DataValidade - DataTime.Now).Days <= 30;
    }
    }
}