using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldemOdds
{
    public class Player
    {
        public int Money { get; set; }
        public HoldemHand hand { get; set; }

        public string Name { get; set; }

        public Player()
        {
            hand = new HoldemHand();
            Money = 100;
        }

        public int Bet()
        {
            Money -= 10;
            return 10;
        }

        public int Raise()
        {
            Money -= 10;
            return 10;
        }
    }
}
