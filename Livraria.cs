
using SQLitePCL;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.MVVM.Models
{
    [Table("livraria")]
    public class Livraria
    {
        [MaxLength(200)]
        public  string nomeDoLivro { get; set; }

        [MaxLength(200)]
        public  string nomeDoAutor { get; set; }

        [MaxLength(200)]
        public string emailDoAutor { get; set; }


        [PrimaryKey, AutoIncrement]
        public int ISBN { get; set; }


        public Livraria() { }

    }
}
