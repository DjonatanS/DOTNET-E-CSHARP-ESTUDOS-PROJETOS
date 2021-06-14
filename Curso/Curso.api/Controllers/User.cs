using Curso.api.Model;
using Curso.api.Model.Usuarios;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.api.Controllers
{
    [Route("api/v1/user")]
    [ApiController]
    public class User : Controller
    {
        [SwaggerResponse(statusCode: 200, "Sucesso", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, "Erro Client Side", Type = typeof(ValidaCampoViewModelOutput))]
        [SwaggerResponse(statusCode: 500, "Erro de Servidor", Type = typeof(ErroGenericoViewModel))]

        [HttpPost]
        [Route("logar")]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            return Ok(loginViewModelInput);
        }


        [HttpPost]
        [Route("register")]
        public IActionResult Registrar(RegistroViewModelInput loginViewModelInput)
        {
            return Created("", loginViewModelInput);
        }
    }
}
