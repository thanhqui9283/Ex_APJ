using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BTVN1.Models;

namespace BTVN1.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<Student> Get()
        {
            var StudentInfList = new List<Student>();
            for (int i = 0; i < 10; i++) {
                var Student = new Student
                {
                    Name = "Nguyễn Thanh Qui",
                    MSV = 5951071086,
                    Age = 22
                };
                StudentInfList.Add(Student);

            }
            return StudentInfList;
        }
        public Student Get(int id)
        {
            return new Student
            {

                Name = "Nguyễn Thanh Qui",
                MSV = 5951071086,
                Age = 22
            }; ;
        }

        // GET: api/Student/5


        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
