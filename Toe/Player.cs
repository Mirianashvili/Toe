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
