using System.ComponentModel.DataAnnotations;

namespace Validacao_Form.Models
{
    public class Denuncia
    {
        public Guid Id { get; set; }
        [Display(Name = "Reclamante")]
        [StringLength(100)]
        public string? Denuciante { get; set; }
        [Display(Name = "Telefone")]
        [StringLength(20)]
        public string? Telefone { get; set; }
        [Display(Name = "e-mail")]
        [StringLength(50)]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Informe o CNPJ")]
        [Display(Name = "CNPJ")]
        [StringLength(50)]
        public string Cnpj { get; set; } = string.Empty;
        [Required(ErrorMessage = "Informe a razão social")]
        [Display(Name = "Razão Social")]
        [StringLength(100)]
        public string RazaoSocial { get; set; } = string.Empty;
        [Required(ErrorMessage = "Informe o endereço")]
        [Display(Name = "Endereço")]
        [StringLength(100)]
        public string Logradouro { get; set; } = string.Empty;
        [Required(ErrorMessage = "Informe o número")]
        [Display(Name = "Número")]
        [StringLength(30)]
        public string Numero { get; set; } = string.Empty;
        [Required(ErrorMessage = "Informe o bairro")]
        [Display(Name = "Bairro")]
        [StringLength(30)]
        public string Bairro { get; set; } = string.Empty;
        [Required(ErrorMessage = "Informe a cidade")]
        [Display(Name = "Cidade")]
        [StringLength(30)]
        public string Cidade { get; set; } = string.Empty;
        [Required(ErrorMessage = "Informe a UF")]
        [Display(Name = "UF")]
        [StringLength(30)]
        public string UF { get; set; } = string.Empty;
        [Display(Name = "País")]
        public string? Pais { get; set; } = "BR";
        [Required(ErrorMessage = "Informe o CEP")]
        [Display(Name = "CEP")]
        [StringLength(10)]
        public string CEP { get; set; } = string.Empty;
        [Required(ErrorMessage = "Informe a denúncia")]
        [Display(Name = "Denúncia")]
        public string Conteudo { get; set; } = string.Empty;
    }
}
