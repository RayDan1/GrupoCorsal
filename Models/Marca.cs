using System.ComponentModel.DataAnnotations;

namespace GrupoCorsal.Models{

    public class Marca{

        [Key]
        public int id { get; set; }
        public string? nombre { get; set; }

    }
    
}