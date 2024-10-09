using Microsoft.AspNetCore.Mvc;
using Senac.Exercicio.Service;

namespace Senac.Exercicio.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IdadeController
    {
        [HttpGet]
        public string ObterIdade(DateTime dataNascimento)
        {
            int idade = new IdadeService().ObterIdade(dataNascimento);
            return $"A pessoa tem {idade} anos";
        }
    }
}
