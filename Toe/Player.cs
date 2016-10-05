using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toe
{
    class Player
    {
        bool player;
        public Player(bool player)
        {
            this.player = player;
        }
        public string PlayerSpecialIcon
        {
            get
            {
                return (player) ? ("X") : ("O");
            }
        }
        public int PlayerSpecialValue
        {
            get
            {
                return (player) ? 10 : 1;
            }
        }
    }
}
