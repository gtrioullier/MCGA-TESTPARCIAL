using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestParcial.Entities;
using TestParcial.Services.Contracts;

namespace TestParcial.UI.Process
{
    public class StudentProcess : ProcessComponent
    {
        public List<Student> SelectList()
        {
            var response = HttpGet<AllResponse>("rest/Student/All", new Dictionary<string, object>(), MediaType.Json);
            return response.Result;
        }

        public void Create(Student student)
        {
            var resquest = HttpPost<Student>("rest/Student/Create", student, MediaType.Json);
        }
    }
}
