using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Foodpackage
    {
        public int Id { get; set; }
        [Required] public double Price { get; set; }
        [Required] public DateTime ExpireDate { get; set; }
        [Required] public string Description { get; set; }

        [Required] public Restaurant Restaurant { get; set; }
        [Required] public Category Category { get; set; }
        public Order Order { get; set; }
        public ICollection<Foodattribute> Foodattribute { get; set; }

    }
}
