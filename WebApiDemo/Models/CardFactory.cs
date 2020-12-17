using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ErrorLogDemoApi.Models
{
    public abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }
}