using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Despesas.Models
{
    [Table("Produto")]

    public class Produto
    {

        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Telefone")]
        [Display(Name = "Fone")]
        public int Fone { get; set; }

        [Column("CNPJ")]
        [Display(Name = "CNPJ")]
        public int CNPJ { get; set; }

        [Column("Preço")]
        [Display(Name = "Preço")]
        public int Preço { get; set; }

        [Column("Emissão")]
        [Display(Name = "Emissão")]
        public int Emissão { get; set; }

        [Column("Vencimento")]
        [Display(Name = "Vencimento")]
        public int Vencimento { get; set; }



    }
}
