using GerenciadorAlimentacao.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciadorAlimentacao.Models
{
    [Table("Refeicao")]
    public class RefeicaoModel
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Column("Tipo")]
        [Display(Name = "Tipo")]
        public TipoEnum Tipo { get; set; }

        [Column("Data")]
        [Display(Name = "Data/Hora")]
        public DateTime Hora { get; set; }

        public virtual PessoaModel Pessoa { get; set; }
    }
}
