using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgramaEstagio.Models.Entidades
{
    [Table("Sale")]
    public class Sale
    {
        [Key]
        [Column("sale_id")]
        [Display(Name = "Código")]
        public string ID { get; set; }

        [Column("description")]
        [Display(Name = "Descrição")]
        [StringLength(150)]
        [Required(ErrorMessage = "O campo \"Descrição\" é de preenchimento obrigatório.")]
        public string Description { get; set; }

        [Column("sale_value")]
        [Display(Name = "Valor da Venda")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "O campo \"Valor da Venda\" é de preenchimento obrigatório.")]
        public decimal SaleValue { get; set; }

        [Column("user_id")]
        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "O campo \"Nome do Cliente\" é de preenchimento obrigatório.")]
        public int UserID { get; set; }

        [Column("sale_date")]
        [Display(Name = "Data da Venda")]
        public DateTime SaleDate { get; set; }
        
        [Display(Name = "Nome do Usuário")]
        public virtual User UserForeignKey { get; set; }
    }
}
