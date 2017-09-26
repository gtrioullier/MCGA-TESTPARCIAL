using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParcial.Data;
using TestParcial.Entities;

namespace TestParcial.Business
{
    public class CountryBusiness
    {
        public List<Country> ALL()
        {
            var countryDAC = new CountryDAC();
            return countryDAC.Select();
        }
    }
}
