using System.ComponentModel.DataAnnotations;

namespace P02_2019MA603_2020VH602_2020VD601.Models
{
    public class reportes
    {
        [Key]
        public int id_reporte { get; set; }
        public int id_departamento { get; set; }
        public int id_genero { get; set; }
        public int confirmados { get; set; }
        public int recuperados { get; set; }
        public int fallecidos { get; set; }
    }
}
