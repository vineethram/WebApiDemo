using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class Overload
    {
        //adding two integer values
        public int Plus(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        // adding three integer values. 
        public int Plus(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
    }
}