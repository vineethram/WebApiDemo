using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;

namespace WebApiDemo.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Person> Get()
        {
            using(DemoDBEntities entities = new DemoDBEntities())
            {
                return entities.People.ToList();
            }
        }

        public Person Get(int id)
        {
            using (DemoDBEntities entities = new DemoDBEntities())
            {
                return entities.People.FirstOrDefault(x=>x.ID==id);
            }
        }

        public void Post([FromBody]Person person)
        {
            using(DemoDBEntities entities = new DemoDBEntities())
            {
                entities.People.Add(person);
                entities.SaveChanges();
            }
        }
        public void Put(int id, [FromBody]Person person)
        {
            using(DemoDBEntities entities = new DemoDBEntities())
            {
                var entity = entities.People.FirstOrDefault(e => e.ID == id);
                entity.ID = person.ID;
                entity.EMPLOYEE_FIRSTNAME = person.EMPLOYEE_FIRSTNAME;
                entity.EMPLOYEE_LASTNAME = person.EMPLOYEE_LASTNAME;
                entity.SALARY = person.SALARY;

                entities.SaveChanges();
            }
        }
    }
}
