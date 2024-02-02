using Assignment4;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        TicTacTools tt = new TicTacTools();
        Console.WriteLine("Welcome to TicTacToe!");
        // Initialize game board with placeholders indicating the position numbers
        string[] gameBoard = new string[9];
        for (int i = 0; i < gameBoard.Length; i++)
        {
            gameBoard[i] = (i + 1).ToString();
        }
        bool winGame = false;
        int player = 0; // Player 0 for 'X', 1 for 'O'
        int turns = 0; // Track the number of turns to check for a draw
        while (!winGame && turns < 9)
        {
            tt.printBoard(gameBoard);
            Console.WriteLine($"Player {(player == 0 ? "X" : "O")}'s turn. Pick a number 1-9:");
            bool goodChoice = false;
            int globalChoice = 0;
            while (!goodChoice)
            {
                string input = Console.ReadLine();
                bool isInt = int.TryParse(input, out int choice);
                if (!isInt || choice < 1 || choice > 9)
                {
                    Console.WriteLine("Please choose a number between 1 and 9.");
                }
                else if (gameBoard[choice - 1] == "X" || gameBoard[choice - 1] == "O")
                {
                    Console.WriteLine("That spot is already taken, please select another spot.");
                }
                else
                {
                    globalChoice = choice;
                    goodChoice = true;
                }
            }
            // Update game board
            gameBoard[globalChoice - 1] = player == 0 ? "X" : "O";
            turns++; // Increment turns after each valid move
                     // Check for winner
            string winner = tt.GetWinner(gameBoard);
            if (winner != null)
            {
                tt.printBoard(gameBoard);
                Console.WriteLine($"Player {winner} won! Thanks for playing!");
                winGame = true;
                break;
            }
            // Toggle player for next turn
            player = 1 - player;
            // Check for draw
            if (turns == 9 && winner == null)
            {
                tt.printBoard(gameBoard);
                Console.WriteLine("The game is a draw! Thanks for playing!");
                break;
            }
        }
    }
}