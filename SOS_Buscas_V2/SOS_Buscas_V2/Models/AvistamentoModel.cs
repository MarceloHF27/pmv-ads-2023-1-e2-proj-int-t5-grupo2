using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS_Buscas_V2.Models
{
    //------------------------------------------------------------------
    //Modelo para a tabela de Avistamentos

    public class AvistamentoModel
    {

        [Key]
        public int Id { get; set; }

        //------------------------------------------------------------------
        //Hora Avistamento

        [Column(TypeName = "DateTime")]
        public DateTime DiaHoraAvistamento { get; set; }

        //------------------------------------------------------------------
        //Estado desaparecido

        [Column(TypeName = "nvarchar(200)")]
        public string DescricaoDesaparecido { get; set; }

        //------------------------------------------------------------------
        //Chaves estrangeiras

        [ForeignKey("IdDesaparecido")]
        public int DesaparecidoId { get; set; }

        public DesaparecidoModel IdDesaparecido { get; set; }



        [ForeignKey("Email")]
        [Column(TypeName = "varchar(45)")]
        public string UserEmail { get; set; }

        public UsuarioModel Email { get; set; }
    }
}
