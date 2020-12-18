using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class DemoCollectionsController : ApiController
    {
        // GET: api/DemoCollections
        public List<ArrayList> Get()
        {
            var result = new List<ArrayList>();
            ArrayList arrayList = new ArrayList() { 45,78,33,56,12,23};
            arrayList.Add(9);

            result.Add(arrayList);
            arrayList.Reverse();
            result.Add(arrayList);
            arrayList.Sort();
            result.Add(arrayList);
            return result;
        }
        [Route("api/democollections/getqueue")]
        [HttpGet]
        public List<string> GetQueue()
        {
            var output = new List<string>();

            Queue demoQueue = new Queue();
            demoQueue.Enqueue("This");
            demoQueue.Enqueue("is");
            demoQueue.Enqueue("a");
            demoQueue.Enqueue("demo");
            demoQueue.Enqueue("string");

            string s = null;

            foreach (var item in demoQueue)
            {
                s = s + " " + item;
            }
            output.Add(s);
            var ch = demoQueue.Dequeue();
            s = $"Removed the string \"{ch}\" from the queue";
            output.Add(s);
            ch = demoQueue.Dequeue();
            s= $"also removed the string \"{ch}\" from the queue";
            output.Add(s);
            output.Add("Remaining Values : ");
            s = null;
            foreach (var item in demoQueue)
            {
                s = s + " " + item;
            }
            output.Add(s);
            return output;
        }

        // GET: api/DemoCollections/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DemoCollections
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DemoCollections/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DemoCollections/5
        public void Delete(int id)

        {
        }
    }
}
