using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class ErrorLogController : ApiController
    {
        ILog logger = log4net.LogManager.GetLogger("ErrorLog");

        public IEnumerable<string> Get()
        {

            try
             {
                throw new Exception("Exception Thrown");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
            return new string[] { "value1", "value2" };
        }
    }
}
