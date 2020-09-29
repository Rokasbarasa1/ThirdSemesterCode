using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Session8.Data.Entities
{
    public class Cat
    {
        public int id;
        [StringLength(20)]
        [Required]
        public String name;
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public String color;
        [Range(0,100)]
        [DataType(DataType.Currency)]
        [Required]
        public decimal price;
        public DateTime birthdate;
        public String favoriteDish;

        public Cat(global::System.Int32 id, String name, String color, global::System.Decimal price, DateTime birthdate, String favoriteDish)
        {
            this.id = id;
            this.name = name;
            Color = color;
            this.price = price;
            this.birthdate = birthdate;
            this.favoriteDish = favoriteDish;
        }
    }
}
