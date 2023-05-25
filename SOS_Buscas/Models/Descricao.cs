using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS_Buscas.Models
    

{
    [Keyless]
    public class Descricao
    {
        
        public string Roupa { get; set; }
        public string TamanhoCabelo { get; set; }
        public string CorCabelo { get; set; }
        public string CorPele { get; set; }
        public string Tatuagem { get; set; }
        public string Observacoes { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }
        [ForeignKey("Desaparecido")]
        public int DesaparecidoID { get; set; }

        public Desaparecido Desaparecido { get; set; }
    }
}
