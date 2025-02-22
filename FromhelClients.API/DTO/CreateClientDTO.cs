using System.ComponentModel.DataAnnotations;

namespace FromhelClients.API.DTO
{
    public record CreateClientDTO
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
    }
}
