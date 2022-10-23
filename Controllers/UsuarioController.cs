using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase 
    {
        [HttpGet("ObeterDataHora")]
        public IActionResult ObterDataHora()
        {
            var obj = new 
            {
                data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok (obj);
        }
        [HttpGet("aprensentar/{nome}")]
        public IActionResult Aprensentar(string nome )
        {
            var mensagem = $"ola {nome} , seja bem vindo ";
            return Ok(new {mensagem});
        }
    }
}