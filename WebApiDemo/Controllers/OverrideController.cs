using LinQtoObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class OverrideController : ApiController
    {
        public List<string> Get()
        {
            var output = new List<string>();
            baseClass obj;
            obj = new baseClass();
            output.Add(obj.show());
            obj = new derivedClass();
            output.Add(obj.show());
            return output;
        }
    }
}
