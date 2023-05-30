using System.ComponentModel.DataAnnotations;

namespace SOS_Buscas.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }   
        public string Email { get; set; }
        public string Senha { get; set; }
        public Desaparecido Desaparecido { get; set;}


        public bool VerificarSenha(string senha)
        {
            return Senha == senha;  
        }

    }
}
