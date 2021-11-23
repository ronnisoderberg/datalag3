using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Costumer
    {
        public int Id { get; set; }
        [Required] public string Name { get; set; }
        public bool? IsBanned { get; set; } = false;

        public ICollection<Order> Order { get; set; }
        public ICollection<Ban> Ban { get; set; }
    }
}
