using System;
using System.Collections.Generic;

#nullable disable

namespace ProjektZespolowy.Models
{
    public partial class EntrepreneursWithProceedings : IEntrepreneur
    {
        public decimal? Lp { get; set; }
        public decimal? NumerEwidencyjny { get; set; }
        public string NumerWpisuDoRejestru { get; set; }
        public decimal? Nip { get; set; }
        public string FirmaLubNazwa { get; set; }
        public string Wojewodztwo { get; set; }
        public string KodPocztowy { get; set; }
        public string Miejscowosc { get; set; }
        public string Ulica { get; set; }
        public string NrDomuLokalu { get; set; }
        public string FormaPrawna { get; set; }
        public DateTime? DataZdarzenia { get; set; }
        public DateTime? DataDoreczenia { get; set; }
        public string StatusKsiegi { get; set; }
    }
}
