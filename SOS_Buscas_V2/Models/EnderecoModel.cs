using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SOS_Buscas_V2.Models
{
    public class EnderecoModel
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "varchar(60)")]
        public string Rua { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string Numero { get; set; }

        [Column(TypeName = "varchar(60)")]
        public string Cidade { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Cep { get; set; }

        [ForeignKey("Email")]
        [Column(TypeName = "varchar(45)")]
        public string EmailUsuario { get; set; }

        public UsuarioModel Email { get; set; }

    }
}
