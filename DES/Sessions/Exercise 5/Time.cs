using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_5
{
    class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public static Time operator +(Time t1, Time t2)
        {
            return new Time
            {
                Hours = t1.Hours + t2.Hours,
                Minutes = t1.Minutes + t2.Minutes
            };
        }

        public static Time operator +(Time t1, int minutes)
        {
            return new Time
            {
                Hours = t1.Hours + (int)Math.Floor(((double)minutes / 60)),
                Minutes = t1.Minutes + (minutes % 60)
            };
        }

        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}";
        }
    }
}
