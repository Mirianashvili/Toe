using System.Windows.Forms;

namespace Toe
{
    class Game
    {
        int[,] board;
        Button[,] boardUI;
        const int BOARD_SIZE = 3;
        bool let;
        
        public Game(Button[,] boardUI)
        {
            this.board = new int[BOARD_SIZE, BOARD_SIZE];
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    board[i, j] = 0;
                }
            }
            this.boardUI = boardUI;
            this.let = true;
        }
        public void Init()
        {
            this.let = true;
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    boardUI[i, j].Text = "";
                    board[i, j] = 0;
                }
            }
        }
        public void Tick(int x, int y)
        {
            Player player = new Player(let);
            if (board[x, y] == 0)
            {
                boardUI[x, y].Text = player.PlayerSpecialIcon;
                board[x, y] = player.PlayerSpecialValue;
                let = !let;
                WhoWinTheGame(win());
            }
        }
        public void WhoWinTheGame(int win)
        {
            switch (win)
            {
                case 2:
                    MessageBox.Show("X win!");
                    Init();
                    break;
                case 1:
                    MessageBox.Show("O Win!");
                    Init();
                    break;
                case 0:
                    MessageBox.Show("Draw");
                    Init();
                    break;
            }
        }
        /*
            2 - X win
            1 - O win
            0 - Draw 
        */
        public int win()
        {
            int sum = 0;
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                sum = board[i, 0] + board[i, 1] + board[i, 2];
                if (sum == 3) return 1;
                if (sum == 30) return 2;
            }
            for (int j = 0; j < BOARD_SIZE; j++)
            {
                sum = board[0, j] + board[1, j] + board[2, j];
                if (sum == 3) return 1;
                if (sum == 30) return 2;
            }
            sum = board[0, 0] + board[1, 1] + board[2, 2];
            if (sum == 3) return 1;
            if (sum == 30) return 2;
            sum = board[1, 1] + board[0, 2] + board[2, 0];
            if (sum == 3) return 1;
            if (sum == 30) return 2;
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    if (board[i, j] == 0)
                    {
                        return -1;
                    }
                }
            }
            return 0;
        }
    }
}
