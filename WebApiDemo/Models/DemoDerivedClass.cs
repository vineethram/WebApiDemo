using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class DemoDerivedClass : AbstractDemo
    {
        public override string demoAbstract()
        {
            
            
            return "overriden derived class invoked";
                 
        }
    }

    public class demoDerivedClass : InterfaceDemo
    {
        public string InterfaceDemo()
        {
            return "interface method implmented";
        }
    }
}