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

        
        public string CPF { get; set; }

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


        [Column(TypeName = "nvarchar(300)")]
        public string? Tatuagem { get; set; }


        //------------------------------------------------------------------
        //Informações sobre o desaparecimento


        [Column(TypeName = "nvarchar(200)")]
        public string Vestimenta { get; set; }


        [Column(TypeName = "DateTime")]
        public DateTime DataHoraDesaparecimento { get; set; }


        //------------------------------------------------------------------
        //Informações extra

        [Column(TypeName = "nvarchar(100)")]
        public string? Medicacoes { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string? Doencas { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string? Transtornos { get; set; }

        //------------------------------------------------------------------
        //Familiares
        [Column(TypeName = "nvarchar(80)")]
        public string NomeFamiliar { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string ContatoFamiliar { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string GrauParentesco { get; set; }


        [Column(TypeName = "nvarchar(80)")]
        public string? NomeFamiliar2 { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string? ContatoFamiliar2 { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string? GrauParentesco2 { get; set; }

        //------------------------------------------------------------------
        //Endereco

        [Column(TypeName = "nvarchar(100)")]
        public string Endereco { get; set; }

        //------------------------------------------------------------------
        //UltimoVistamento

        [Column(TypeName = "nvarchar(100)")]
        public string Avistamento { get; set; }


        //------------------------------------------------------------------
        //Informações extra


        [Column(TypeName = "nvarchar(300)")]
        public string? Observacoes { get; set; }


        //------------------------------------------------------------------
        //Chaves estrangeiras

        [ForeignKey("Email")]
        [Column(TypeName = "varchar(45)")]
        public string EmailUsuario { get; set; }

        public UsuarioModel Email { get; set; } 
    }
}
