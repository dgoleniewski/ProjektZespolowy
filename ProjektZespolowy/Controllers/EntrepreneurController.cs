using Microsoft.AspNetCore.Mvc;
using ProjektZespolowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespolowy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntrepreneurController : ControllerBase
    {
        CompanyDataAccessLayer db = new CompanyDataAccessLayer();

        // GET: api/<EntrepreneurController>
        [HttpGet("removed")]
        public IEnumerable<IEntrepreneur> GetAllCompaniesRemoved()
        {
            return db.GetAllCompaniesRemoved();
        }

        [HttpGet("proceedings")]
        public IEnumerable<IEntrepreneur> GetAllCompaniesWithProceedings()
        {
            return db.GetAllCompaniesWithProceedings();
        }

        [HttpGet("prohibition")]
        public IEnumerable<IEntrepreneur> GetAllCompaniesWithProhibition()
        {
            return db.GetAllCompaniesWithProhibition();
        }

        // GET api/<EntrepreneurController>/5
        [HttpGet("{id}")]
        public IEntrepreneur Get(string id)
        {
            return db.GetEntrepreneur(id);
        }
    }
}
