using System.ComponentModel.DataAnnotations.Schema;

namespace RestDotNet5.Model
{
    [Table("pessoa")]
    public class Pessoa
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("sobrenome")]
        public string Sobrenome { get; set; }
        [Column("endereco")]
        public string Endereco { get; set; }
        [Column("genero")]
        public string Genero { get; set; }

    }
}
