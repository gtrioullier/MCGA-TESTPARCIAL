using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParcial.Entities;
using TestParcial.Services.Contracts;

namespace TestParcial.UI.Process
{
    public class CountryProcess : ProcessComponent
    {
        public List<Country> SelectList()
        {
            var response = HttpGet<AllResponseCountry>("rest/Country/All", new Dictionary<string, object>(), MediaType.Json);
            return response.Result;
        }
    }
}
