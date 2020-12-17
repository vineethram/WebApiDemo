using EmployeeDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class LinqtoObjectController : ApiController
    {
        // GET: api/LinqtoObject
        
        public IEnumerable<Person> Get()
        {

            using (DemoDBEntities entities = new DemoDBEntities())
            {
                IEnumerable<Person> query = (from emp in entities.People
                                             where emp.SALARY >= 30000
                                             orderby emp.SALARY
                                             select emp).ToList();
                return query;
            }
            

        }

        [Route("api/linqtoobject/getiqueryable")]
        [HttpGet]

        public IQueryable<Person> GetIqueryable()
        {

            using (DemoDBEntities entities = new DemoDBEntities())
            {
                IQueryable<Person> query = (from emp in entities.People
                                             where emp.SALARY >= 30000
                                             orderby emp.SALARY
                                             select emp).AsQueryable();
                return query;
            }


        }

        // GET: api/LinqtoObject/5
        public string Get(int id)
        {
            return "value";
        }
        
    }
}
