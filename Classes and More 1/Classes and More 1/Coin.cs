using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_More_1
{
    public class Coin
    {
        public String sideUp;

       public Coin()
        {
            sideUp = "Head";
        }

        public Coin(String sideUp)
        {
            this.sideUp = sideUp;
        }

        public void toss()
        {
            Random rand = new Random();
            if (rand.Next(2) == 0)
            {
                sideUp = "Head";
            }
            else
            {
                sideUp = "Tail";
            }
        }

        public String getSideUp()
        {
            return sideUp;
        }
    }
}



