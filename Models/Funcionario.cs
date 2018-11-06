using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApi_DotNetCore.Models
{
    public class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Chave{get; set;}
        public string Nome{get;set;}
        public bool EstaComplata{get;set;}
    }
}