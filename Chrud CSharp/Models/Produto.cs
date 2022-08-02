using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chrud_CSharp.Models
{
    [Table("Produto")]   
    public class Produto
    {
        [Column("Id")]
        [Display(Name ="Codigo")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]

        public string Nome { get; set; }
    }
}
