using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorAlimentacao.Models
{
    public class PessoaModel
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public virtual ICollection<RefeicaoModel> ListaRefeicoes { get; set; }
        public virtual ICollection<SonoModel> ListaSono { get; set; }
    }
}
