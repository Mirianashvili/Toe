using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toe
{
    public partial class Form1 : Form
    {
        Game myGame;
        public Form1()
        {
            InitializeComponent();

            Button[,] boardUI = new Button[3, 3];
            
            boardUI[0,0] = button1;
            boardUI[0,1] = button2;
            boardUI[0,2] = button3;

            boardUI[1,0] = button4;
            boardUI[1,1] = button5;
            boardUI[1,2] = button6;

            boardUI[2,0] = button7;
            boardUI[2,1] = button8;
            boardUI[2,2] = button9;
            
            myGame = new Game(boardUI); 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            myGame.Init();
        }

        private void BoardButtonsClick(object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender;
            int x = Convert.ToInt32(ClickedButton.Tag.ToString()[0]) - 48;
            int y = Convert.ToInt32(ClickedButton.Tag.ToString()[1]) - 48;
            myGame.Tick(x, y);
        }
        
    }
}
