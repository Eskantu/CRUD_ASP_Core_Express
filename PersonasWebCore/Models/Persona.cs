using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonasWebCore.Models
{
    public class Persona
    {
        
        public int IdPersona { get; set; }
        [Required(AllowEmptyStrings =false, ErrorMessage ="El nombre es un campo obligatorio")]
        public string Nombre { get; set; }
        public string Genero { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime FechaNacimiento { get; set; }
        public bool Trabaja { get; set; }
        public int NumeroDeTrabajos { get; set; }

    }
}
