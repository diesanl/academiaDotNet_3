using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorEventos.Models
{
    public class PessoaModel
    {
        [Key]
        [Display(Name = "Código")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public virtual ICollection<RefeicaoModel> ListaRefeicoes { get; set; }
        public virtual ICollection<SonoModel> ListaSono { get; set; }
    }
}
