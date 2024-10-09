using Microsoft.VisualBasic;

namespace Senac.Exercicio.Service
{
    public class IdadeService
    {
        public int ObterIdade(DateTime dtNasc)
        {
            DateTime dtHoje = DateTime.Now;
            int resultado;
            resultado = dtHoje.Year - dtNasc.Year;
            if (dtNasc.Month < dtNasc.Month || (dtHoje.Month == dtNasc.Month && dtHoje.Day < dtNasc.Day))
                resultado--;
            return resultado;
        }
    }
}
