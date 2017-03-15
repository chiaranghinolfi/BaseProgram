using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProgram
{
        public class Madre
        {
            private string _nome;
            public string nome { get; set; }

            private string _cognome;
            public string cognome { get; }

            private string _codiceFiscale;
            public string codiceFiscale { get; set; }

            private DateTime _dataNascita;
            public DateTime dataNascita { get; set; }
         
            //VEDERE PER DATA DI NASCITA
            public Madre (string nome, string cognome, string codiceFiscale)
            {
                this.nome = nome;
                this.cognome = cognome;
                this.codiceFiscale = codiceFiscale;
                this.dataNascita = DateTime.Today.Date;
            }

            public virtual string describe()
            {
                string output = "Nome: " + nome + "\r\n";
                output += "Cognome: " + cognome + "\r\n";
                output += "Data di nascita: " + dataNascita + "\r\n";
                output += "Codice Fiscale: " + codiceFiscale + "\r\n";
                

                return output;
            }

            public override string ToString()
            {
                return (nome + " " + cognome + " " + dataNascita).ToString();
            }

}
}
