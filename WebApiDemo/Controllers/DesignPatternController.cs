using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ErrorLogDemoApi.Models;

namespace ErrorLogDemoApi.Controllers
{
    public class DesignPatternController : ApiController
    {
        // GET: api/DesignPattern
        /*public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        // GET: api/DesignPattern/5
        public string Get(string card)
        {
            CardFactory factory = null;
            switch(card.ToLower())
            {
                case "moneyback" :
                    factory = new MoneyBackFactory(50000, 0);
                    break;
                case "titanium":
                    factory = new TitaniumFactory(100000, 500);
                    break;
                case "platinum":
                    factory = new PlatinumFactory(500000, 1000);
                    break;
                default:
                    break;
            }
            var creditCard = factory.GetCreditCard();

            var cardDetails = $" Card Type : {creditCard.CardType}  Credit Limit : {creditCard.CreditLimit}  Annual Charges : {creditCard.AnnualCharge}";

            return cardDetails;
        }
    }
}
