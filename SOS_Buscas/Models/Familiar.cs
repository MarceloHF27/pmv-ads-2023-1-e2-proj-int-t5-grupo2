using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS_Buscas.Models
{
    public class Familiar
    {
        [Key]
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public string parentesco { get; set; }
        [ForeignKey("Desaparecido")]
        public int DesaparecidoID { get; set; } 
        public Desaparecido Desaparecido { get; set;}
    }
}
