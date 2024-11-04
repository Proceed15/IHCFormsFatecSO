using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace IHCFormsFatecSO.Models
{
    public class Estabelecimento
    {
        [Display(Name = "CNPJ (básico)")]
        [StringLength(8)]
        public string CnpjBasico { get; set; } = string.Empty;
        [Display(Name = "CNPJ (ordem)")]
        [StringLength(4)]
        public string CnpjOrdem { get; set; } = string.Empty;
        [Display(Name = "CNPJ (DV)")]
        [StringLength(2)]
        public string CnpjDv { get; set; } = string.Empty;
        [Display(Name = "Nome Fantasia")]
        [StringLength(200)]
        public string? NomeFantasia { get; set; } = string.Empty;
        [Display(Name = "Data da situação cadastral")]
        public DateTime? DataSituacaoCadastral { get; set; }
        [Display(Name = "CNAE Principal")]
        [StringLength(100)]
        public string CnaePrincipal { get; set; } = string.Empty;
        [Display(Name = "Tipo de logradouro")]
        [StringLength(100)]
        public string TpLogradouro { get; set; } = string.Empty;
        [Display(Name = "Logradouro")]
        [StringLength(500)]
        public string Logradouro { get; set; } = string.Empty;
        [Display(Name = "Número")]
        [StringLength(500)]
        public string? Numero { get; set; } = string.Empty;
        [Display(Name = "Complemento")]
        [StringLength(500)]
        public string Complemento { get; set; } = string.Empty;
        [Display(Name = "Bairro")]
        [StringLength(500)]
        public string Bairro { get; set; } = string.Empty;
        [Display(Name = "CEP")]
        [StringLength(10)]
        public string? CEP { get; set; }

        [Display(Name = "UF")]
        [StringLength(30)]
        public string UF { get; set; } = string.Empty;
        [Display(Name = "Cidade")]
        [StringLength(100)]
        public string Cidade { get; set; } = string.Empty;
        [Display(Name = "E-Mail")]
        [StringLength(100)]
        public string? Email { get; set; } = string.Empty; // e-mail
    }
}
