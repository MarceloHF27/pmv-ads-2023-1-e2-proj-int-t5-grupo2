using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SOS_Buscas_V2.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOS_Buscas_V2.Models
{
    //------------------------------------------------------------------
    //Modelo para a tabela de Desaparecidos
    public class DesaparecidoModel
    {
    

        [Key]
        public int Id { get; set; }

        //------------------------------------------------------------------
        //Informações Gerais

        [Column(TypeName = "varchar(80)")]
        public string NomeCompleto { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string CaminhoImagem { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string EstiloCorCabelo { get; set; }


        [Column(TypeName = "varchar(15)")]
        public string CorPele { get; set; }


        [Column(TypeName = "varchar(5)")]
        public double Altura { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string? Tatoagem { get; set; }


        //------------------------------------------------------------------
        //Informações sobre o desaparecimento


        [Column(TypeName = "nvarchar(100)")]
        public string Vestimenta { get; set; }


        [Column(TypeName = "DateTime")]
        public DateTime DataHoraDesaparecimento { get; set; }


        //------------------------------------------------------------------
        //Informações extra

        [Column(TypeName = "nvarchar(100)")]
        public string? Mediacacoes { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string? Doencas { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string? Transtornos { get; set; }


        //------------------------------------------------------------------
        //Informações extra


        [Column(TypeName = "nvarchar(250)")]
        public string? Observacoes { get; set; }


        //------------------------------------------------------------------
        //Chaves estrangeiras

        [ForeignKey("Email")]
        [Column(TypeName = "varchar(45)")]
        public string EmailUsuario { get; set; }

        public UsuarioModel Email { get; set; } 
    }
}
