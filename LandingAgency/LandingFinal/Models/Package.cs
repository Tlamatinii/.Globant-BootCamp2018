using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LandingFinal.Patterns;

namespace LandingFinal.Models
{
    public class Package
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(30)]
        [Display(Name ="Package Name")]
        public string PackageName { get; set; }

        public List<Product> Products { get; set; }

        public Package() { }

        public Package(Guid packageId, string packageName)
        {
            this.Id = packageId;
            this.PackageName = packageName;
        }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}