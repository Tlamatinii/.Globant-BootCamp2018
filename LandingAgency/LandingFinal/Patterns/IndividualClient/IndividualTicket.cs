using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LandingFinal.Models;

namespace LandingFinal.Patterns.Commision.IndividualClient
{
    public class IndividualTicket : CalculateCommision
    {       
        public override float CalculateProductCommision(Product product, int Nights)
        {
            return product.Price * 0.1f;
        }
    }
}
