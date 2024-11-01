using System.ComponentModel.DataAnnotations;

namespace BancoRodrigo.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "La contrase�a es obligatoria.")]
        public string Contrase�a { get; set; }
    }
}
