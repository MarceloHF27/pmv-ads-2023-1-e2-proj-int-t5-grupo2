using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS_Buscas.Models
{
    [Keyless]
    public class LocalAvistamento
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
        public string   PontoReferencia { get; set; }
        [ForeignKey("HistoricoAvistamento")]
        public int AvistamentoID { get; set; }


        public HistoricoAvistamento HistoricoAvistamento { get; set; }  
    }
}
