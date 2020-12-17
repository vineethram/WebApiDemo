using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ErrorLogDemoApi.Models
{
    public abstract class CreditCard
    {
        public abstract string CardType { get; }
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualCharge { get; set; }

    }
}