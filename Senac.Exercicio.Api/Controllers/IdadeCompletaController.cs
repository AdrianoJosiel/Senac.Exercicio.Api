using Microsoft.AspNetCore.Mvc;
using Senac.Exercicio.Service;

namespace Senac.Exercicio.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IdadeCompletaController : ControllerBase
    {
        private readonly IdadeCompletaService _idadeService;

        public IdadeCompletaController()
        {
            _idadeService = new IdadeCompletaService();
        }

        [HttpGet]
        public IActionResult ObterIdadeCompleta(DateTime dataNascimento)
        {
            var idade = _idadeService.ObterIdadeCompleta(dataNascimento);
            return Ok($"A pessoa tem {idade.Anos} anos, {idade.Meses} meses e {idade.Dias} dias.");
        }
    }
}
