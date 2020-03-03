using System;
using System.Collections.Generic;
using System.Text;

namespace BigCarStore
{
    public static class PrekiuOperacijos
    {
        public static void PrekesPirkimas(Preke naujaPreke)
        {
            //issaugome duomenu bazeje
            naujaPreke.UnikalusNumeris = Guid.NewGuid().ToString();
            PrekesRepository.IdetiNauja(naujaPreke);

        }

        public static List<Preke> PrekiuKatalogas()
        {
            //pasiimame is DB
            return PrekesRepository.GetPrekesKatalogas();
        }

        public static List<Preke> PrekiuPaieska(string kriterijus)
        {
            var pagalPavadinima = PrekesRepository.PaieskaPagalPavadinima(kriterijus);
            var pagalNumeri = PrekesRepository.PaieskaPagalUnikaluNr(kriterijus);
            pagalPavadinima.AddRange(pagalNumeri);
            return pagalPavadinima;
        }
    }
}
