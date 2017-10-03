using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TestParcial.Entities;
using TestParcial.Data;


namespace TestParcial.Business
{
    /// <summary>
    /// Student business component.
    /// </summary>
    public class StudentBusiness
    {

        public List<Student> All()
        {
            var studentDAC = new StudentDAC();
            return studentDAC.Select();

        }
        public void Add(Student student)
        {
            var studentDAC = new StudentDAC();
            studentDAC.Create(student);
        }
    }
}
