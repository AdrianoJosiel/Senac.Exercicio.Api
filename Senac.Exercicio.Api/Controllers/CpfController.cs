using Microsoft.AspNetCore.Mvc;
using Senac.Exercicio.Service;

namespace Senac.Exercicio.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CpfController
    {
        [HttpGet()]
        public string ValidarCpf(string cpf)
        {
            bool resultado = new CpfService().ValidarCpf(cpf);
            if (resultado)
                return "CPF Válido!";
            return "CPF Inválido!";

           // return resultado ? "CPF Válido" : "CPF Inválido"; //exemplo usando if ternario
            
        }
    }
}
