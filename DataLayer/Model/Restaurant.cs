using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }
        public string Phonenumber { get; set; }

        public ICollection<Foodpackage> Foodpackage { get; set; }

    }
}
