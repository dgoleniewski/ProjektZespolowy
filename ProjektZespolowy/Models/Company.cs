using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespolowy.Models
{
    public class Company
    {
        public int Id { get; set; }
        public int NumerEwidencyjny { get; set; }
        public string NumerWpisuDoRejestru { get; set; }
        public int NIP { get; set; }
        public string Firma { get; set; }
        public string Wojewodztwo { get; set; }
        public string KodPocztowy { get; set; }
        public string Miejscowosc { get; set; }
        public string Ulica { get; set; }
        public string NrDomu { get; set; }
        public string FormaPrawna { get; set; }
        public DateTime DataZdarzenia { get; set; }
        public DateTime DataDoreczenia { get; set; }
        public string StatusKsiegi { get; set; }
    }
}
