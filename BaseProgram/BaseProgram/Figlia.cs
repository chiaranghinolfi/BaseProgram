using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProgram
{
    class Figlia : Madre
    {
        public string scuola { get; set; }

        public Figlia (string nome, string cognome, string codiceFiscale, string scuola) : base(nome, cognome, codiceFiscale)
        {
            this.scuola = scuola;
        }

        public override string describe()

        {
            string output = "Nome: " + nome + "\r\n";
            output += "Cognome: " + cognome + "\r\n";
            output += "Data di nascita: " + dataNascita + "\r\n";
            output += "Codice Fiscale: " + codiceFiscale + "\r\n";
            output += "Scuola: " + scuola + "\r\n";
            return output;
        }
    }
}


