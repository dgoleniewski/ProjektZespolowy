using System;
using System.Collections.Generic;

#nullable disable

namespace ProjektZespolowy.Models
{
    public partial class EntrepreneursDeleted : IEntrepreneur
    {
        public string Lp { get; set; }
        public string NumerEwidencyjny { get; set; }
        public string NrWpisuDoRejestru { get; set; }
        public string Nip { get; set; }
        public string DataWpisuDoEwidencji { get; set; }
        public string FirmaLubNazwa { get; set; }
        public string Wojewodztwo { get; set; }
        public string KodPocztowy { get; set; }
        public string Miejscowosc { get; set; }
        public string Ulica { get; set; }
        public string NrDomuLokalu { get; set; }
        public string FormaPrawna { get; set; }
        public string RodzajZdarzenia { get; set; }
        public string DataDecyzji { get; set; }
        public string DataDoreczenia { get; set; }
        public string DataObowiazywaniaZakazuOd { get; set; }
        public string DataObowiazywaniaZakazuDo { get; set; }
        public string StatusKsięgi { get; set; }
    }
}
