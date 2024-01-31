using Assignment4;

TicTacTools tt = new TicTacTools();

internal class Program
{
    private static void Main(string[] args)
    {
        //Welcome the user
        Console.WriteLine("Welcome to TicTacToe!");

        //Create game board array
        string[] gameBoard = new string[9];
        bool WinGame = false;
        int player = 0;
        bool goodChoice = false;
        int globalChoice = 0;
        char X = 'X';
        char O = 'O';

        //Ask players for their choice
        while (!WinGame)
        {
            Console.WriteLine("Where would you like to play? Pick a number 1-9.");

            while (!goodChoice)
            {
                int choice = Console.ReadLine();
                bool isInt = int.TryParse(choice, out _);
                //Check if choice is already used/acceptable
                if (!isInt)
                {
                    Console.WriteLine("Please choose a number between 1 and 9");
                }
                else if ((choice > 9) | (choice < 1))
                {
                    Console.WriteLine("Please choose a number between 1 and 9");
                }
                else if (gameBoard[(choice - 1)].Contains("X") | (gameBoard[choice - 1].Contains("O")))
                {
                    Console.WriteLine("That spot is already taken, please select another spot.");
                }
                else
                {
                    globalChoice = choice;
                    goodChoice = true;
                }
            }
            //Update game board
            if (player == 0)
            {
                gameBoard[(globalChoice - 1)] = X.ToString();
                tt.winnername(gameBoard);
            }
            else
            {
                gameBoard[(globalChoice - 1)] = O.ToString();
                tt.winnername(gameBoard);
            }
            //Print board by calling method in TicTacTools
            tt.printBoard(gameBoard); //check this

            //Check for winner by calling method in TicTacTools & notify players who won

        }
        Console.WriteLine(f"Player {playername} won! Thanks for playing!");
    }
}