using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class DataTypesController : ApiController
    {
        [Route("api/datatypes/demogetstring")]
        [HttpGet]
        public List<string> DemoGetString()
        {
            var output = new List<string>();
            var output1 = new List<string>();

            var s = "This is is an Example for String";

           foreach(var item in s.Split())
            {
                output.Add(item);
                output1.Add(item);
            }


            output.Sort();

            var isConsecutive = false;
            for (var i = 0; i < output.Count-1; i++)
            {
                if (output[i] == output[i + 1])
                {
                    isConsecutive = true;
                    break;
                }
            }
            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            output1.Add(message);
            return output1;
        }

        [Route("api/datatypes/demogetint")]
        [HttpGet]
        public List<int> DemoGetInt()
        {
            var output = new List<int>();

            List<int> s = new List<int>{ 1,5,2,0,9,10,4,2};
            foreach(var item in s)
            {
                output.Add(item);
            }

            output.Sort();

            var isConsecutive = false;
            for (var i = 0; i < output.Count-1; i++)
            {
                if (output[i] == output[i +1])
                {
                    isConsecutive = true;
                    break;
                }
            }
            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            if (message == "consecutive")
            {
                isConsecutive = false;
                for (var i = 0; i < output.Count - 1; i++)
                {
                    if (output[i] == output[i + 1])
                    {
                        isConsecutive = true;
                        output[i + 1] = 0;
                        output.Sort();
                        break;
                    }

                }
            }

         return output;
        }
    }
}
