using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactBook.Core.COMMON.Interfaces;
using ContactBook.Core.COMMON.Models;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PersonasWebCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TipoContactoController : Controller
    {
        private readonly ITipoContactoManager _tipoContactoManager;
        public TipoContactoController(ITipoContactoManager tipoContactoManager)
        {
            _tipoContactoManager = tipoContactoManager;
        }
        // GET: api/TipoContacto
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tipoContactoManager.ObtenerTodos(new SpParametros("select * from TipoContacto")));
        }

        // GET: api/TipoContacto/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_tipoContactoManager.ObtenerTodos(new SpParametros($"select * from TipoContacto where IdTipoContacto = {id}")));
        }

        // POST: api/TipoContacto
        [HttpPost]
        public IActionResult Post(TipoContacto value)
        {
            return Ok(_tipoContactoManager.Crear(new SpParametros($"insert into TipoContacto(Nombre) values('{value.Nombre}')")));
        }

        // PUT: api/TipoContacto
        [HttpPut]
        public IActionResult Put(TipoContacto value)
        {
            return Ok(_tipoContactoManager.Actualizar(new SpParametros($"UPDATE TipoContacto SET Nombre='{value.Nombre}' WHERE IdTipoContacto={value.IdTipoContacto}")));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_tipoContactoManager.Eliminar(new SpParametros($"DELETE FROM TipoContacto WHERE IdTipoContacto={id}")));
        }
    }
}
