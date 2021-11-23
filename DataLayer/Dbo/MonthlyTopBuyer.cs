using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Dbo
{
    public class MonthlyTopBuyer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Orders { get; set; }
        public decimal Sum { get; set; }
        public int Year { get; set; }
        public string Month { get; set; }
    }
}
