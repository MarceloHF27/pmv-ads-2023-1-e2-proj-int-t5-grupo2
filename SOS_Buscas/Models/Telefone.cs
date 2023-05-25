using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS_Buscas.Models
{
    [Keyless]
    public class Telefone
    {
        public int Cod_Area { get; set; }
        public string Numero { get; set; }
        [ForeignKey("Desaparecido")]
        public int DesaparecidoID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        [ForeignKey("Familiar")]
        public int FamiliarID { get; set; }



        public User User { get; set; }
        public Desaparecido Desaparecido { get; set; }
        public Familiar Familiar { get; set; }

    }
}
