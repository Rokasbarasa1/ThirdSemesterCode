using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Session6_Z_SDJ3
{
    public class Person
    {
        public String name { get; set; }
        public String Position { get; set; }
        public int age { get; set; }
        public bool happy { get; set; }

        public Person(String name, String position, int age, bool happy)
        {
            this.name = name;
            Position = position;
            this.age = age;
            this.happy = happy;
        }
    }
}
