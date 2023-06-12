using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS_Buscas_V2.Models
{
    
    public class EnderecoModel
    {
        [Key]
        public int Id { get; set; }    

        [Column(TypeName = "varchar(20)")]
        public string Rua { get; set; }

        [Column(TypeName = "varchar(6)")]
        public string Numero { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string Complemento { get; set; }


        [Column(TypeName = "varchar(20)")]
        public string Bairro { get; set; }


        [Column(TypeName = "varchar(15)")]
        public string Municipio { get; set; }


        [Column(TypeName = "varchar(2)")]
        public string UF { get; set; }




        [ForeignKey("IdDesaparecido")]
        public int? DesaparecidoId { get; set; }

        public DesaparecidoModel IdDesaparecido { get; set; }



        [ForeignKey("Email")]
        [Column(TypeName = "varchar(45)")]
        public string? UserEmail { get; set; }

        public UsuarioModel Email { get; set; }
    }
}
