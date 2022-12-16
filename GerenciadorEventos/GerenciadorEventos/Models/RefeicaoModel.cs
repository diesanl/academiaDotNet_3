
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorEventos.Models
{
    [Table("Refeicao")]
    public class RefeicaoModel
    {
        [Key]
        [Display(Name = "Código")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }


        [Display(Name = "Tipo")]
        public string Tipo { get; set; }

        [Display(Name = "Data/Hora")]
        public DateTime Hora { get; set; }

        public int PessoaId { get; set; }
        public virtual PessoaModel Pessoa { get; set; }
    }
}
