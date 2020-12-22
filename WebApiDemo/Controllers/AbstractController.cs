using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class AbstractController : ApiController
    {
        public Dictionary<string,string> Get()
        {
            var output = new Dictionary<string, string>();

            var obj = new DemoDerivedClass();
            //var obj1 = new AbstractDemo();

            output.Add("Message from Derived Class", obj.demoAbstract());

            return output;
        }
    }
}
