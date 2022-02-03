using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToec
    {
        public char[] board;
        public TicTacToec()
        {
            board = new char[10];
        }
        public void CreateBoard()
        {
            TicTacToec game = new TicTacToec();
            for (int position = 1; position < 10; position++)
            {
                game.board[position] = ' ';
            }
        }
    }
    
}
