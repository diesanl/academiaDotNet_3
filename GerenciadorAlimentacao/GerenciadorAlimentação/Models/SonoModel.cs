using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorAlimentacao.Models
{
    public class SonoModel
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Horário (Início)")]
        public DateTime HorarioInicio { get; set; }

        [Display(Name = "Horário (Fim)")]
        public DateTime HorarioFim { get; set; }

        public virtual PessoaModel Pessoa { get; set; }
    }
}
