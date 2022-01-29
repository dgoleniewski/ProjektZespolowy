using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespolowy.Models
{
    public class CompanyDataAccessLayer
    {
        ProjektZespolowyContext context = new ProjektZespolowyContext();

        public IEnumerable<EntrepreneursWithProhibition> GetAllCompaniesWithProhibition()
        {
            try
            {
                return context.EntrepreneursWithProhibition.ToList();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<EntrepreneursWithProceedings> GetAllCompaniesWithProceedings()
        {
            try
            {
                return context.EntrepreneursWithProceedings.ToList();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<EntrepreneursDeleted> GetAllCompaniesRemoved()
        {
            try
            {
                return context.EntrepreneursDeleted.ToList();
            }
            catch
            {
                throw;
            }
        }

        public IEntrepreneur GetEntrepreneur(string nip)
        {
            try
            {
                var EntrepreneursWithProhibition = context.EntrepreneursWithProhibition.Where(x => x.Nip == nip);
                if (EntrepreneursWithProhibition.Count() == 1)
                    return EntrepreneursWithProhibition.First();
                var EntrepreneursWithProceedings = context.EntrepreneursWithProceedings.Where(x => x.Nip == decimal.Parse(nip));
                if (EntrepreneursWithProceedings.Count() == 1)
                    return EntrepreneursWithProceedings.First();
                var EntrepreneursDeleted = context.EntrepreneursDeleted.Where(x => x.Nip == nip);
                if (EntrepreneursDeleted.Count() == 1)
                    return EntrepreneursDeleted.First();
                return null;
            }
            catch
            {
                throw;
            }
        }
    }
}
