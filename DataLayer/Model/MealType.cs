using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class MealType
    {
        [Key]
        public int TypeId { get; set; }
        [MaxLength(10)]
        public string Type { get; set; }

    }
}
