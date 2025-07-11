namespace Estoque.Domain.Entities
{
    public class Estoque : EntityBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
         public int Id { get; set; }
        public int QuantidadeAtual { get; set; }
        public int QuantidadeMinima { get; set; }
        public int QuantidadeMaxima { get; set; }
        public int PontoReposicao { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public bool NecessitaReposicao => QuantidadeAtual <= PontoReposicao;
    }
}