using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class MethodInjection
    {
        public interface ISet
        {
           string print();
        }
        public class service : ISet
        {
            public string print()
            {
                return "print........";
            }
        }
        public class client
        {
            private ISet _set;
            public string run(ISet serve)
            {
                this._set = serve;
                return("start" + this._set.print());
                
            }
        }
    }
}