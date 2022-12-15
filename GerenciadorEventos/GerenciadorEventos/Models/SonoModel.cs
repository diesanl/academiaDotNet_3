using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorEventos.Models
{
    public class SonoModel
    {
        [Key]
        [Display(Name = "Código")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Horário (Início)")]
        public DateTime HorarioInicio { get; set; }

        [Display(Name = "Horário (Fim)")]
        public DateTime HorarioFim { get; set; }

        public virtual PessoaModel Pessoa { get; set; }
    }
}
