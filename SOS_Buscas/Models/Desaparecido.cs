using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS_Buscas.Models
{
    public class Desaparecido
    {
        
        
            
        [Key]
        public int ID { get; set; }
        public int Idade { get; set; }  
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataDesaparecimento { get; set; }
        public string HoraDesaparecimento { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        

    }
}
