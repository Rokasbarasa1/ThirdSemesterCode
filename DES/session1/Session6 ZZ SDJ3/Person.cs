using System;
using System.Collections.Generic;
using System.Text;

namespace Session6_ZZ_SDJ3
{
    class Person
    {
        private string name { get; set; }
        private string Position { get; set; }
        private int age { get; set; }
        private bool happy { get; set; }

        public Person(string name, string position, int age, bool happy)
        {
            this.name = name;
            Position = position;
            this.age = age;
            this.happy = happy;
        }
    }
}
