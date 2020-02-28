using System;
using System.Collections.Generic;
using System.Text;

namespace BigCarStore
{
    public class Preke
    {
        public string Pavadimas { get; set; }
        public Guid UnikalusNumeris { get; set; }
        public PrekesTipasEnum PrekesTipas { get; set; }
        public int PirkimoKaina { get; set; }
        public int PardavimoKaina { get; set; }
    }
}
