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
            naujaPreke.UnikalusNumeris = Guid.NewGuid();
            PrekesRepository.IdetiNauja(naujaPreke);

        }

        public static List<Preke> PrekiuKatalogas()
        {
            //pasiimame is DB
            return PrekesRepository.GetPrekesKatalogas();
        }

    }
}
