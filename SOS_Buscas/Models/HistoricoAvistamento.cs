using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS_Buscas.Models
{
    public class HistoricoAvistamento
    {
        [Key]
        public int ID { get; set; }
        public DateTime DataDesaparecimento { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        [ForeignKey("Desaparecido")]
        public int DesaparecidoID { get; set; }

        public User User { get; set; }
        public Desaparecido Desaparecido { get; set; }
    }
}
