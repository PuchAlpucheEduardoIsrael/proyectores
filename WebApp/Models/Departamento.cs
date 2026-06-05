using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Departamento
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Debe proporcionar el titulo del departamento")]
        public string Titulo { get; set; } = string.Empty;

        //Propiedad de navegación de la realación
        public IEnumerable<Proyector> Proyectores { get; set; }
    }
}
