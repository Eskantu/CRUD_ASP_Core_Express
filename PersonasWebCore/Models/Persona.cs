using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonasWebCore.Models
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Trabaja { get; set; }
        public int NumeroDeTrabajos { get; set; }

    }
}
