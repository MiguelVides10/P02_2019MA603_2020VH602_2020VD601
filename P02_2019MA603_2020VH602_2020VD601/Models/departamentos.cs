using System.ComponentModel.DataAnnotations;

namespace P02_2019MA603_2020VH602_2020VD601.Models
{
    public class departamentos
    {
        [Key]
        public int id_departamento { get; set; }
        public string? departamento { get; set; }
    }
}
