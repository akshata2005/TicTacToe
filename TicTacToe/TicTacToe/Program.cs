using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            TicTacToec game = new TicTacToec();
            game.CreateBoard();
        }
    }
}
