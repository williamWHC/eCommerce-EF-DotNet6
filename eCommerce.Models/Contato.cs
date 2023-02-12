namespace eCommerce.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string? Telefone { get; set; }
        public string? Celular { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
