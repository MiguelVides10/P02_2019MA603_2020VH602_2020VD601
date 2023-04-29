

using System.ComponentModel.DataAnnotations;

namespace P02_2019MA603_2020VH602_2020VD601.Models
{
    public class generos
    {
        [Key]
        public int id_genero { get; set; }
        public string? genero { get; set; }
    }
}
