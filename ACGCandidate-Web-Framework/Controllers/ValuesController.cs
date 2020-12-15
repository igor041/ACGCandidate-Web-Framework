using ACGCandidate_Web_Framework.Models;
using ACGCandidate_Web_Framework.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ACGCandidate_Web_Framework.Controllers
{
    public class ValuesController : ApiController
    {
        private IValuesRepo _repo;

        public ValuesController() { }

        public ValuesController(IValuesRepo repo)
        {
            _repo = repo;
        }

        // GET api/values
        public IEnumerable<Person> GetPersons()
        {
            // TODO: Swap this once you plug in ninject
            return _repo.GetPersons();            
            //return ValuesRepo.GetPersonsStatic();
        }
    }
}
