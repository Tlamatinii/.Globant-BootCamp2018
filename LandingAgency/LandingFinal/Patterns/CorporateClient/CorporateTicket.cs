using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LandingFinal.Models;

namespace LandingFinal.Patterns.Commision.CorporateClient
{
    public class CorporateTicket : CalculateCommision
    {
        public override float CalculateProductCommision(Product product, int Nights)
        {
            return product.Price * 2;
        }
    }
}