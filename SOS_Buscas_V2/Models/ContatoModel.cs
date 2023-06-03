using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS_Buscas_V2.Models
{
    public class ContatoModel
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Celular { get; set; }

        [Column(TypeName = "varchar(60)")]
        public string EmailContato { get; set; }

        [ForeignKey("Email")]
        [Column(TypeName = "varchar(45)")]
        public string EmailUsuario { get; set; }

        public UsuarioModel Email { get; set; }
    }
}

