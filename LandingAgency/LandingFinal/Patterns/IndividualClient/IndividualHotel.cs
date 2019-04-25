using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LandingFinal.Models;

namespace LandingFinal.Patterns.Commision.IndividualClient
{
    public class IndividualHotel : CalculateCommision
    {
        public override float CalculateProductCommision(Product product, int Nights)
        {
            if (Nights < 6)
            {
                return product.Price / 2;
            }
            else
            {
                return product.Price * Nights / 6;
            }
        }
    }
}
