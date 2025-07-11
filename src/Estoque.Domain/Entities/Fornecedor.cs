namespace Estoque.Domain.Entities
{
    public class Fornecedor : EntityBase
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; } = [];
    }
}