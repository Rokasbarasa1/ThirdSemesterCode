using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session8.Data.Entities
{
    public class Order
    {
        public int id;
        public DateTime orderDate;
        public String orderNumber;
        public ICollection<Cat> cats;

    }
}
