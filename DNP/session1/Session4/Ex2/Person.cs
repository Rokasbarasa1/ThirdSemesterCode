using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Session4.Ex2
{   [Serializable]
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }
    }
}
