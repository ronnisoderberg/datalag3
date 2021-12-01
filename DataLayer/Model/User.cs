using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Backend;

namespace DataLayer.Model
{
    public class User
    {
        public int Id { get; set; }
        [Required]public string Username { get; set; }
        [Required] public string Password { get; set; }
        [Required] public string Name { get; set; }
        public bool? IsBanned { get; set; } = false;
        public bool IsAdmin { get; set; } = false;
        public ICollection<Order> Order { get; set; }
        public ICollection<Ban> Ban { get; set; }
    }
}
