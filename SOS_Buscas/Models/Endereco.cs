using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS_Buscas.Models
{
    public class Endereco
    {
        [Key]
        public int CEP { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Municipio { get; set; }
        public string Bairro { get; set; }
        public string UF { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        [ForeignKey("Desaparecido")]
        public int DesaparecidoID { get; set; }


        public User User { get; set; }
        public Desaparecido Desaparecido { get; set;}


}
}
