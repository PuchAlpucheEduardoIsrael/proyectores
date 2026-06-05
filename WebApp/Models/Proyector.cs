using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Proyector
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un valor para el campo Marca")]
        [StringLength(24)]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un valor para el campo Modelo")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Debe proporcionar un valor para el campo Número de Serie")]
        public string NumeroDeSerie { get; set; }

        public SituacionProyector Situacion { get; set; }
            = SituacionProyector.Bueno;
        [DataType(DataType.Date)]
        public DateTime FechaDeAlta { get; set; } =DateTime.Now;
        [DataType(DataType.Date)]
        public DateTime? FechaDeBaja { get; set; } = null;

        public int DepartamentoId { get; set; } 

        // Propiedades de navegación de la relación
        public Departamento Departamento { get; set; }
    }

    public enum SituacionProyector
    {
        Bueno=1,
        Regular,
        Malo
    }
}
