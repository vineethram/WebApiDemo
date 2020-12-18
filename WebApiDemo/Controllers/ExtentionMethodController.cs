using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoClassLibrary;
using WebApiDemo.Models;    

namespace WebApiDemo.Controllers
{
    public class ExtentionMethodController : ApiController
    {
        // GET: api/ExtentionMethod
        public IEnumerable<string> Get()
        {
            var output = new List<string>();
            var Obj = new DemoClass();
            output.Add(Obj.Display());
            output.Add(Obj.Print());
            output.Add(Obj.NewMethod());


            return output;
        }
    }
}
