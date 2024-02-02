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

        public string GetWinner(string[] gameBoard)
        {
            
            for (int i = 0; i < 9; i += 3)
            {
                if (gameBoard[i] == gameBoard[i + 1] && gameBoard[i + 1] == gameBoard[i + 2])
                {
                    return gameBoard[i];
                }
            }

            
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[i] == gameBoard[i + 3] && gameBoard[i + 3] == gameBoard[i + 6])
                {
                    return gameBoard[i];
                }
            }

           
            if (gameBoard[0] == gameBoard[4] && gameBoard[4] == gameBoard[8])
            {
                return gameBoard[0];
            }
            if (gameBoard[2] == gameBoard[4] && gameBoard[4] == gameBoard[6])
            {
                return gameBoard[2];
            }

            // if no winner
            return null;
        }

    }

}
