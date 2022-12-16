using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TesteGerenciador
{
    public class SonoModel
    {
        
        public int Id { get; set; }

        
        public DateTime HorarioInicio { get; set; }

        
        public DateTime HorarioFim { get; set; }

        
        public virtual PessoaModel Pessoa { get; set; }
    }
}
