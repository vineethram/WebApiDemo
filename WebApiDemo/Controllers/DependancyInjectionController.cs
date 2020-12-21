using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;
using static WebApiDemo.Models.MethodInjection;

namespace WebApiDemo.Controllers
{
    public class DependancyInjectionController : ApiController
    {
       public string Get()
        {
            constructorinjection cs = new constructorinjection(new format());

            client cn = new client();
            

            return (cs.print()+" " + cn.run(new service()));
        }
    }
}
