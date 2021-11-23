using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Foodattribute
    {
        public int Id { get; set; }
        [Required] public string Attribute { get; set; }

        public ICollection<Foodpackage> Foodpackage  { get; set; }

    }
}
