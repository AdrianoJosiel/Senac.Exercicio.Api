namespace Senac.Exercicio.Service
{
    public class IdadeCompletaService
    {
        public (int Anos, int Meses, int Dias) ObterIdadeCompleta(DateTime dtNasc)
        {
            DateTime dtHoje = DateTime.Now;

            int anos = dtHoje.Year - dtNasc.Year;
            int meses = dtHoje.Month - dtNasc.Month;
            int dias = dtHoje.Day - dtNasc.Day;
           
            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(dtHoje.Year, dtHoje.Month);
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            return (anos, meses, dias);
        }
    }
}
