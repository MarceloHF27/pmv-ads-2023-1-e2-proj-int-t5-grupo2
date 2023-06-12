using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS_Buscas_V2.Models
{
    [Keyless]
    public class LocalAvistamentoModel
    {
        //------------------------------------------------------------------
        //Local do avistamento

        [Column(TypeName = "varchar(20)")]
        public string? Rua { get; set; }


        [Column(TypeName = "varchar(20)")]
        public string Bairro { get; set; }


        [Column(TypeName = "varchar(15)")]
        public string Municipio { get; set; }


        [Column(TypeName = "varchar(2)")]
        public string UF { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string? PontoReferencia { get; set; }


        //------------------------------------------------------------------
        //Chaves estrangeiras

        [ForeignKey("IdAvistamento")]
        public int AvistamentoID { get; set; }

        public AvistamentoModel IdAvistamento { get; set; }
    }
}
