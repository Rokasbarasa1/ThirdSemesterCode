using System;
using System.Collections.Generic;
using System.Text;

namespace Session3
{
    class Player
    {
        private String shout;

        public Player()
        {

        }

        public void Shout(String line)
        {
            Console.WriteLine(line);
        }

        public void Shout(int number)
        {
            Console.WriteLine("{0} is my lucky number!", number);
        }
        
        public void Shout(Enemy enemy)
        {
            Console.WriteLine("The enemy can do {0} damage to me.", enemy.getDMg());
        }
    }
}
