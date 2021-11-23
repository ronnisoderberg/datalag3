using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Ban
    {
        public int BanId { get; set; }
        public string Reason { get; set; }
        [Required] public DateTime BannedDate { get; set; } = DateTime.Today;
        public DateTime? BannedLift { get; set; } 

        [Required] public Costumer Costumer { get; set; } 
    }
}
