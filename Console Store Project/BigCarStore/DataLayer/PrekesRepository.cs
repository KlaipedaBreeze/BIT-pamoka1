using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigCarStore
{
    public static class PrekesRepository
    {
        private static List<Preke> prekes = new List<Preke>();
        // private static List<Preke> _prekes = new List<Preke>();
        private static string _fileName = "prekes.xml";

        private static List<Preke> _prekes
        {
            get
            {
                //Nuskaityti faila ir deserelizuoti

                var failoSaugojimoPrietaisas = new SaveToFile();
                try
                {
                    prekes = failoSaugojimoPrietaisas.DeSerializeObject<List<Preke>>(_fileName);
                }
                catch (Exception)
                {
                    prekes = new List<Preke>();
                }

                // jei failo nera ar klaida sukurti tuscia masyva
                return prekes;
            }

            set
            {
                //serelizuoti objekta ir irasyti i faila
                prekes = value;
            }
        }

        private static void Save()
        {
            var failoSaugojimoPrietaisas = new SaveToFile();
            failoSaugojimoPrietaisas.SerializeObject<List<Preke>>(prekes, _fileName);
        }


        public static void IdetiNauja(Preke preke)
        {
            if (_prekes.Exists(x => x.UnikalusNumeris.Equals(preke.UnikalusNumeris)))
            {
                throw new Exception("Tokia preke siuo numeriu jau egzistuoja");
            }

            _prekes.Add(preke);
            Save();
        }

        public static List<Preke> GetPrekesKatalogas()
        {

            return _prekes;
        }

        public static List<Preke> PaieskaPagalPavadinima(string kriterijus)
        {
            return _prekes.Where(x => x.Pavadimas.ToUpper().Contains(kriterijus.ToUpper())).ToList();
        }

        public static List<Preke> PaieskaPagalUnikaluNr(string kriterijus)
        {
            return _prekes.Where(x => x.UnikalusNumeris.ToUpper().Contains(kriterijus.ToUpper())).ToList();
        }

    }
}
