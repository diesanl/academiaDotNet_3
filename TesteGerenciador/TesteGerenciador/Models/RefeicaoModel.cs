
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteGerenciador
{

    public class RefeicaoModel
    {

        public int Id { get; set; }


        public string Descricao { get; set; }


        public string Tipo { get; set; }


        public DateTime Hora { get; set; }

        public virtual PessoaModel Pessoa { get; set; }
    }
}
