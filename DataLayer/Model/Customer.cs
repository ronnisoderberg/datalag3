using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        [MaxLength(25)]
        public string FirstName { get; set; }
        [MaxLength(25)]

        public string LastName { get; set; }
        [MaxLength(50)]

        public string Email { get; set; }
        [MaxLength(20)]

        public string PhoneNumber { get; set; }
        [MaxLength(25)]

        public string City { get; set; }
        [MaxLength(10)]

        public string ZipCode { get; set; }
        [MaxLength(100)]

        public string Street { get; set; }
        
        public ICollection<Order> Orders { get; set; } 
    }
}
