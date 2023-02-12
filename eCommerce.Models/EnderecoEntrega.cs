namespace eCommerce.Models
{
    public class EnderecoEntrega
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string? NomeEndereco { get; set; }
        public string? CEP { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        public string? Bairro { get; set; }
        public string? Endereco { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public Contato? Contato { get; set; }
        public Usuario? Usuario { get; set; }
    }
}