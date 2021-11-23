using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace DataLayer.Dbo
{
    public class CustomerStatistics
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int OrdersPlaced { get; set; }
        public decimal Sum { get; set; }
    }
}
