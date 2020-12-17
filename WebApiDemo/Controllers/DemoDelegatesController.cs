using LinQtoObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

public delegate int NumberChanger(int n);

namespace WebApiDemo.Controllers
{
    public class DemoDelegatesController : ApiController
    {
        private int res;

        // GET: api/DemoDelegates
        public Dictionary<string,int> Get()
        {
            var output = new Dictionary<string, int>();
            
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(DemoDelegate.AddNum);
            NumberChanger nc2 = new NumberChanger(DemoDelegate.MulNum);
            var res1 = nc1(10);
            var res2 = nc2(10);
            nc = nc1 + nc2;

            output.Add("NC1(10)",nc1(10));
            output.Add("NC2(10)", nc2(10));
            output.Add("Num",DemoDelegate.Num);
            output.Add("MultiCast Delegate : nc(10)",nc(10)); //Multicast Delegate
            

            Func<int, int, int> Addition = delegate (int n1, int n2)
            {
                return n1 + n2;
            };

            int result = Addition(10, 20);
            output.Add("Final Addition Result",result);

            Action<int, int> AdditionAction = (param1, param2) => res = param1 + param2;
            AdditionAction(10, 20);
            output.Add("Action Delegate example - Addition result", res);            

            Predicate<string> DemoPredicate = Check;
            bool checkresult = Check("If this is a string");
            if (checkresult) output.Add("Predicate example Check Passed",1);
            else output.Add("Predicate example Check Failed", 0);

            return output;
        }

        private static bool Check(string s)
        {
            if (s == "If this is a string") return true;
            else return false;
        }   
    }
}
