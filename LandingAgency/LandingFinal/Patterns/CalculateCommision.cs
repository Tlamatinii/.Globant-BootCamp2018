using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LandingFinal.Models;

namespace LandingFinal.Patterns
{
    public abstract class CalculateCommision
    {
        public abstract float CalculateProductCommision(Product products, int Nights);
    }
}