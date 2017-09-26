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
    [RoutePrefix("rest/Student")]
    public class StudentService : ApiController
    {
        [HttpGet]
        [Route("All")]
        public AllResponse All()
        {
            var response = new AllResponse();
            var studentBussines = new StudentBusiness();
            response.Result = studentBussines.All();
            return response;
        }

        [HttpPost]
        [Route("Create")]
        public void Create(Student student)
        {
            var studentBussines = new StudentBusiness();
            studentBussines.Add(student);
        }
    }
}

