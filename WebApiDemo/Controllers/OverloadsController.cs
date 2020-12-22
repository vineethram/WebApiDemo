using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class OverloadsController : ApiController
    {
        public Dictionary<string, int> Get()
        {
            var output = new Dictionary<string, int>();

            var DemoOverload = new Overload();

            var a = 10;
            var b = 20;
            var c = 30;

            output.Add($"Overload Example 1 with 2 paramaters {a}, {b}",DemoOverload.Plus(a, b));
            output.Add($"Overload Example 2 with 3 paramaters {a}, {b}, {c}", DemoOverload.Plus(a, b, c));

            int i;
            Addition(out i);
            output.Add("Example of Out Parameter (30 + (30*2)",i);


            return output;

        }
        public static void  Addition(out int i)
        {
            i = 30;
            i += i * 2;
        }
    }
}
