using PersonasWebCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonasWebCore.Servicios.Interfaces
{
    public interface IPersonaManager
    {
        Persona Crear(Persona persona);
        IEnumerable<Persona> Obtener();
        bool Actualizar(Persona persona);
        bool Eliminar(int id);
        Persona SearchById(int id);
    }
}
