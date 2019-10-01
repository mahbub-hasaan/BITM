using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITM_Works.Models
{
    class Orders
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public double TotalPrice { get; set; }
    }
}
