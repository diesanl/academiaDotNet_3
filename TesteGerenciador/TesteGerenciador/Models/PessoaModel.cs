using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteGerenciador
{
    public class PessoaModel
    {
        
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public int RefeicaoId { get; set; }
        public virtual ICollection<RefeicaoModel> ListaRefeicoes { get; set; }

        public int SonoId { get; set; }
        public virtual ICollection<SonoModel> ListaSono { get; set; }
    }
}
