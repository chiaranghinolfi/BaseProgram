using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProgram
{
    class lista
    {
        public List<Madre> elenco = new List<Madre>();

        public void aggiungi(Madre m)
        {
            elenco.Add(m);
        }
    }
}
