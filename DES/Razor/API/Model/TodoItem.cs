using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class TodoItem
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public bool IsComplete { get; set; }

        override
        public string ToString()
        {
            return Id + ";" + Name + ";" + Description + ";" + IsComplete;
        }
    }
}
