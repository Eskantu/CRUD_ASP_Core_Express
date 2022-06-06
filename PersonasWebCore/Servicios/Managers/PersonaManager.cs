using PersonasWebCore.Models;
using PersonasWebCore.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonasWebCore.Servicios.Managers
{
    public class PersonaManager:IPersonaManager
    {
        private List<Persona> personas;
        public PersonaManager()
        {
            personas = new List<Persona>();
        }

        public bool Actualizar(Persona persona)
        {
            int index = personas.FindIndex(p=>p.IdPersona==persona.IdPersona);
            personas[index] = persona;
            return true;
        }

        public Persona Crear(Persona persona)
        {
            personas.Add(persona);
            return persona;
        }

        public bool Eliminar(int id)
        {
            return personas.RemoveAll(p => p.IdPersona == id) > 0;
        }

        public IEnumerable<Persona> Obtener()
        {
            return personas;
        }

        public Persona SearchById(int id)
        {
            return personas.FirstOrDefault(p => p != null);
        }
    }
}
