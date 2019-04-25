using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using LandingFinal.Patterns;

namespace LandingFinal.Models
{
    public class Client
    {
        public ClientEnum ClientType { get; set; }
    }
}