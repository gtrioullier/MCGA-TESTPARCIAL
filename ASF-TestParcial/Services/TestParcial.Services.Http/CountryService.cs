using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestParcial.Business;
using TestParcial.Entities;
using TestParcial.Services.Contracts;

namespace TestParcial.Services.Http
{
    [RoutePrefix("rest/Country")]
    public class CountryService : ApiController
    {
        [HttpGet]
        [Route("All")]
        public AllResponseCountry All()
        {
            var response = new AllResponseCountry();
            var countryBussines = new CountryBusiness();
            response.Result = countryBussines.ALL();
            return response;
        }
    }
}
