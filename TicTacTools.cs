using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class TicTacTools
    {

        public void printBoard(string[] gameBoard)//gameBoard array as param
        {
            Console.WriteLine($" {gameBoard[0]} | {gameBoard[1]} | {gameBoard[2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {gameBoard[3]} | {gameBoard[4]} | {gameBoard[5]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {gameBoard[6]} | {gameBoard[7]} | {gameBoard[8]} ");
        }

        public void winnerName()
        {

        }

    }
}
