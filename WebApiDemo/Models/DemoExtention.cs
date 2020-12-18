using DemoClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public static class DemoExtention
    {
        public static string NewMethod(this DemoClass demoClass)
        {
            return "this is the new method";
        }
    }
}