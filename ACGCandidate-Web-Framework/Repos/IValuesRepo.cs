using ACGCandidate_Web_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACGCandidate_Web_Framework.Repos
{
    public interface IValuesRepo
    {
        IList<Person> GetPersons(); // Not sure what to enforce here regarding 3 values? check with Jon...
    }
}
