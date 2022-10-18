using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBoston.DATA
{
    public class CafeData
    {
        public int TableCount { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> ActiveOreders { get; set; }
        public List<Order> PastOreders { get; set; }
    }
}
