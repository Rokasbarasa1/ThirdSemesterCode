using System;
using System.Collections.Generic;
using System.Text;

namespace Session2
{
    class DNPStudent : Student
    {
        public override void SayHi()
        {
            Console.WriteLine("Hi, I am a DNP student!");
            base.SayHi();
        }
    }
}
