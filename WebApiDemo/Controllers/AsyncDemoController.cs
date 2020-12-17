using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;


namespace WebApiDemo.Controllers
{

    public class AsyncDemoController : ApiController
    {
        public List<string> output = new List<string>();
        public List<string> Get()
        {
            var output = new List<string>();
            output = (Method1().Result);
            output.AddRange(Method2());


            return output;
        }
        public static async Task<List<string>> Method1()
        {
            int i;
            List<string> result = new List<string>();
            await Task.Run(() =>
            {
                for (i = 0; i < 5; i++)
                {
                    result.Add($" Method 1 - {i + 1}th execution");
                }

            });
            return result;
        }
        public static List<string> Method2()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < 2; i++)
            {
                result.Add($" Method 2 - {i + 1}th execution");
            }
            return result;
        }
    }
}
