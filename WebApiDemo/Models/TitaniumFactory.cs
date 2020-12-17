using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ErrorLogDemoApi.Models
{
    public class TitaniumFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualLimit;
        public TitaniumFactory(int creditLimit, int annualLimit)
        {
            _creditLimit = creditLimit;
            _annualLimit = annualLimit;
        }
        public override CreditCard GetCreditCard()
        {
            return new TitaniumCreditCard(_creditLimit, _annualLimit);
        }
    }
}