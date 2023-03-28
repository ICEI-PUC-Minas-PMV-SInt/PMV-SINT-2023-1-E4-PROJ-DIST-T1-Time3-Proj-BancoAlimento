using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_web_service_bma.Models
{
    [Table("Beneficiarios")]
    public class Beneficiario
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Nome { get; set; }
        [Required]

        public string Cpf { get; set; }
        [Required]

        public string Data_nascimento { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]

        public string Telefone { get; set; }
        [Required]

        public string Cep { get; set; }
        [Required]

        public string Logradouro { get; set; }
        [Required]

        public string Numero { get; set; }
        [Required]

        public string Complemento { get; set; }
        [Required]

        public string Bairro { get; set; }
        [Required]

        public string Cidade { get; set; }
        [Required]

        public string Uf { get; set; }
        [Required]

        public string Situacao { get; set; }
        [Required]

        public string Perfil_acesso { get; set; }
        [Required]

        public string  beneficio_cesta_basica { get; set; }
        [Required]

        public string beneficio_cesta_verde { get; set; }
      

    }
}
