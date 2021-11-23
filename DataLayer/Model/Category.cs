using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Category
    {   
        [Key] public string Type { get; set; }

        public ICollection<Foodpackage> Foodpackage { get; set; }
    }
}
