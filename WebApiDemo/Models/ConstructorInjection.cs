using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public interface IText
    {
        string print();
    }
    class format : IText
    {
        public string print()
        {
            return ("This is text format");
        }
    }
    // constructor injection
    public class constructorinjection
    {
        private IText _text;
        public constructorinjection(IText t1)
        {
            this._text = t1;
        }
        public string print()
        {
            return _text.print();
        }
    }
}