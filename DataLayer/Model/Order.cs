using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Order
    {
        public int Id { get; set; }
        [Required] public DateTime OrderDate { get; set; } 
        public double OrderSum { get; set; }

        [Required] public User User { get; set; }
         public ICollection<Foodpackage> Foodpackage { get; set; }

    }
}
