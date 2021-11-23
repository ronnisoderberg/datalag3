using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Meal
    {
        [Key]
        public int MealId { get; set; }
        [MaxLength(100)]
        public string MealName { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("RestaurantId")]
        public Restaurant Restaurant { get; set; }
        [ForeignKey("TypeId")]
        public MealType MealType { get; set; }
      
        public Order Order { get; set; }
    }
}
