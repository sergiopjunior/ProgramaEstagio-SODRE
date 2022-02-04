using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgramaEstagio.Models.Entidades
{
    [Table("User")]
    public class User
    {
        [Key]
        [Column("user_id")]
        [Display(Name = "Código")]
        public int ID { get; set; }

        [Column("first_name")]
        [Display(Name = "Nome")]
        [StringLength(50)]
        [Required(ErrorMessage = "O campo \"Nome\" é de preenchimento obrigatório.")]
        public string FirstName { get; set; }

        [Column("last_name")]
        [Display(Name = "Sobrenome")]
        [StringLength(150)]
        [Required(ErrorMessage = "O campo \"Sobrenome\" é de preenchimento obrigatório.")]
        public string LastName { get; set; }

        [Column("birth_date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Nascimento")]       
        [Required(ErrorMessage = "O campo \"Data de Nascimento\" é de preenchimento obrigatório.")]
        public DateTime BirthDate { get; set; }

        [Column("registration_date")]
        [Display(Name = "Data de Cadastro")]      
        public DateTime RegistrationDate { get; set; }

        [Column("gender")]
        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "O campo \"Gênero\" é de preenchimento obrigatório.")]
        public string Gender { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
